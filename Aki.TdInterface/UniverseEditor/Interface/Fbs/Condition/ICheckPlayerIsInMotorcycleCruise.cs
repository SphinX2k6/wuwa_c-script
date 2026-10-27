using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF0 RID: 19184
	public struct ICheckPlayerIsInMotorcycleCruise : IFlatbufferObject
	{
		// Token: 0x17008B1A RID: 35610
		// (get) Token: 0x0601E254 RID: 123476 RVA: 0x0043A5AE File Offset: 0x004387AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E255 RID: 123477 RVA: 0x0043A5BB File Offset: 0x004387BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E256 RID: 123478 RVA: 0x0043A5C4 File Offset: 0x004387C4
		public static ICheckPlayerIsInMotorcycleCruise GetRootAsICheckPlayerIsInMotorcycleCruise(ByteBuffer _bb)
		{
			return ICheckPlayerIsInMotorcycleCruise.GetRootAsICheckPlayerIsInMotorcycleCruise(_bb, default(ICheckPlayerIsInMotorcycleCruise));
		}

		// Token: 0x0601E257 RID: 123479 RVA: 0x0043A5E0 File Offset: 0x004387E0
		public static ICheckPlayerIsInMotorcycleCruise GetRootAsICheckPlayerIsInMotorcycleCruise(ByteBuffer _bb, ICheckPlayerIsInMotorcycleCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E258 RID: 123480 RVA: 0x0043A5FD File Offset: 0x004387FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E259 RID: 123481 RVA: 0x0043A60C File Offset: 0x0043880C
		public ICheckPlayerIsInMotorcycleCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B1B RID: 35611
		// (get) Token: 0x0601E25A RID: 123482 RVA: 0x0043A61C File Offset: 0x0043881C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B1C RID: 35612
		// (get) Token: 0x0601E25B RID: 123483 RVA: 0x0043A658 File Offset: 0x00438858
		public bool IsInMotorcycleCruise
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E25C RID: 123484 RVA: 0x0043A697 File Offset: 0x00438897
		public static Offset<ICheckPlayerIsInMotorcycleCruise> CreateICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsInMotorcycleCruise = false)
		{
			builder.StartTable(2);
			ICheckPlayerIsInMotorcycleCruise.AddIsInMotorcycleCruise(builder, IsInMotorcycleCruise);
			ICheckPlayerIsInMotorcycleCruise.AddType(builder, Type);
			return ICheckPlayerIsInMotorcycleCruise.EndICheckPlayerIsInMotorcycleCruise(builder);
		}

		// Token: 0x0601E25D RID: 123485 RVA: 0x0043A6B4 File Offset: 0x004388B4
		public static void StartICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E25E RID: 123486 RVA: 0x0043A6BD File Offset: 0x004388BD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E25F RID: 123487 RVA: 0x0043A6C8 File Offset: 0x004388C8
		public static void AddIsInMotorcycleCruise(FlatBufferBuilder builder, bool isInMotorcycleCruise)
		{
			builder.AddBool(1, isInMotorcycleCruise, false);
		}

		// Token: 0x0601E260 RID: 123488 RVA: 0x0043A6D3 File Offset: 0x004388D3
		public static Offset<ICheckPlayerIsInMotorcycleCruise> EndICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerIsInMotorcycleCruise>(builder.EndTable());
		}

		// Token: 0x0601E261 RID: 123489 RVA: 0x0043A6E0 File Offset: 0x004388E0
		public ICheckPlayerIsInMotorcycleCruiseT UnPack()
		{
			ICheckPlayerIsInMotorcycleCruiseT checkPlayerIsInMotorcycleCruiseT = new ICheckPlayerIsInMotorcycleCruiseT();
			this.UnPackTo(checkPlayerIsInMotorcycleCruiseT);
			return checkPlayerIsInMotorcycleCruiseT;
		}

		// Token: 0x0601E262 RID: 123490 RVA: 0x0043A6FB File Offset: 0x004388FB
		public void UnPackTo(ICheckPlayerIsInMotorcycleCruiseT _o)
		{
			_o.Type = this.Type;
			_o.IsInMotorcycleCruise = this.IsInMotorcycleCruise;
		}

		// Token: 0x0601E263 RID: 123491 RVA: 0x0043A718 File Offset: 0x00438918
		public static Offset<ICheckPlayerIsInMotorcycleCruise> Pack(FlatBufferBuilder builder, ICheckPlayerIsInMotorcycleCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerIsInMotorcycleCruise>);
			}
			return ICheckPlayerIsInMotorcycleCruise.CreateICheckPlayerIsInMotorcycleCruise(builder, _o.Type, _o.IsInMotorcycleCruise);
		}

		// Token: 0x0400D381 RID: 54145
		private Table __p;
	}
}
