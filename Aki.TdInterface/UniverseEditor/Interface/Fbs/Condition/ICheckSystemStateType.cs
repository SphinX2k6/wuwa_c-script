using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B44 RID: 19268
	public struct ICheckSystemStateType : IFlatbufferObject
	{
		// Token: 0x17008BCB RID: 35787
		// (get) Token: 0x0601E54B RID: 124235 RVA: 0x0043FFF8 File Offset: 0x0043E1F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E54C RID: 124236 RVA: 0x00440005 File Offset: 0x0043E205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E54D RID: 124237 RVA: 0x0044000C File Offset: 0x0043E20C
		public static ICheckSystemStateType GetRootAsICheckSystemStateType(ByteBuffer _bb)
		{
			return ICheckSystemStateType.GetRootAsICheckSystemStateType(_bb, default(ICheckSystemStateType));
		}

		// Token: 0x0601E54E RID: 124238 RVA: 0x00440028 File Offset: 0x0043E228
		public static ICheckSystemStateType GetRootAsICheckSystemStateType(ByteBuffer _bb, ICheckSystemStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E54F RID: 124239 RVA: 0x00440045 File Offset: 0x0043E245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E550 RID: 124240 RVA: 0x00440054 File Offset: 0x0043E254
		public ICheckSystemStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BCC RID: 35788
		// (get) Token: 0x0601E551 RID: 124241 RVA: 0x00440064 File Offset: 0x0043E264
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

		// Token: 0x0601E552 RID: 124242 RVA: 0x004400A0 File Offset: 0x0043E2A0
		public static Offset<ICheckSystemStateType> CreateICheckSystemStateType(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding)
		{
			builder.StartTable(1);
			ICheckSystemStateType.AddType(builder, Type);
			return ICheckSystemStateType.EndICheckSystemStateType(builder);
		}

		// Token: 0x0601E553 RID: 124243 RVA: 0x004400B6 File Offset: 0x0043E2B6
		public static void StartICheckSystemStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E554 RID: 124244 RVA: 0x004400BF File Offset: 0x0043E2BF
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E555 RID: 124245 RVA: 0x004400CA File Offset: 0x0043E2CA
		public static Offset<ICheckSystemStateType> EndICheckSystemStateType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemStateType>(builder.EndTable());
		}

		// Token: 0x0601E556 RID: 124246 RVA: 0x004400D8 File Offset: 0x0043E2D8
		public ICheckSystemStateTypeT UnPack()
		{
			ICheckSystemStateTypeT checkSystemStateTypeT = new ICheckSystemStateTypeT();
			this.UnPackTo(checkSystemStateTypeT);
			return checkSystemStateTypeT;
		}

		// Token: 0x0601E557 RID: 124247 RVA: 0x004400F3 File Offset: 0x0043E2F3
		public void UnPackTo(ICheckSystemStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E558 RID: 124248 RVA: 0x00440104 File Offset: 0x0043E304
		public static Offset<ICheckSystemStateType> Pack(FlatBufferBuilder builder, ICheckSystemStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemStateType>);
			}
			return ICheckSystemStateType.CreateICheckSystemStateType(builder, _o.Type);
		}

		// Token: 0x0400D3ED RID: 54253
		private Table __p;
	}
}
