using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200502B RID: 20523
	public struct ICheckSystemStateType : IFlatbufferObject
	{
		// Token: 0x170092DB RID: 37595
		// (get) Token: 0x060200D7 RID: 131287 RVA: 0x004727FC File Offset: 0x004709FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060200D8 RID: 131288 RVA: 0x00472809 File Offset: 0x00470A09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060200D9 RID: 131289 RVA: 0x00472810 File Offset: 0x00470A10
		public static ICheckSystemStateType GetRootAsICheckSystemStateType(ByteBuffer _bb)
		{
			return ICheckSystemStateType.GetRootAsICheckSystemStateType(_bb, default(ICheckSystemStateType));
		}

		// Token: 0x060200DA RID: 131290 RVA: 0x0047282C File Offset: 0x00470A2C
		public static ICheckSystemStateType GetRootAsICheckSystemStateType(ByteBuffer _bb, ICheckSystemStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060200DB RID: 131291 RVA: 0x00472849 File Offset: 0x00470A49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060200DC RID: 131292 RVA: 0x00472858 File Offset: 0x00470A58
		public ICheckSystemStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092DC RID: 37596
		// (get) Token: 0x060200DD RID: 131293 RVA: 0x00472868 File Offset: 0x00470A68
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060200DE RID: 131294 RVA: 0x004728A4 File Offset: 0x00470AA4
		public static Offset<ICheckSystemStateType> CreateICheckSystemStateType(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding)
		{
			builder.StartTable(1);
			ICheckSystemStateType.AddType(builder, Type);
			return ICheckSystemStateType.EndICheckSystemStateType(builder);
		}

		// Token: 0x060200DF RID: 131295 RVA: 0x004728BA File Offset: 0x00470ABA
		public static void StartICheckSystemStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060200E0 RID: 131296 RVA: 0x004728C3 File Offset: 0x00470AC3
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060200E1 RID: 131297 RVA: 0x004728CE File Offset: 0x00470ACE
		public static Offset<ICheckSystemStateType> EndICheckSystemStateType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemStateType>(builder.EndTable());
		}

		// Token: 0x060200E2 RID: 131298 RVA: 0x004728DC File Offset: 0x00470ADC
		public ICheckSystemStateTypeT UnPack()
		{
			ICheckSystemStateTypeT checkSystemStateTypeT = new ICheckSystemStateTypeT();
			this.UnPackTo(checkSystemStateTypeT);
			return checkSystemStateTypeT;
		}

		// Token: 0x060200E3 RID: 131299 RVA: 0x004728F7 File Offset: 0x00470AF7
		public void UnPackTo(ICheckSystemStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060200E4 RID: 131300 RVA: 0x00472908 File Offset: 0x00470B08
		public static Offset<ICheckSystemStateType> Pack(FlatBufferBuilder builder, ICheckSystemStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemStateType>);
			}
			return ICheckSystemStateType.CreateICheckSystemStateType(builder, _o.Type);
		}

		// Token: 0x0400DEEC RID: 57068
		private Table __p;
	}
}
