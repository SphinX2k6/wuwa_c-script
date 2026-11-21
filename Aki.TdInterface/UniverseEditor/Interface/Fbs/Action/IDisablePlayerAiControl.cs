using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C59 RID: 27737
	public struct IDisablePlayerAiControl : IFlatbufferObject
	{
		// Token: 0x1700CB6E RID: 52078
		// (get) Token: 0x0602FC52 RID: 195666 RVA: 0x00681ADB File Offset: 0x0067FCDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC53 RID: 195667 RVA: 0x00681AE8 File Offset: 0x0067FCE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC54 RID: 195668 RVA: 0x00681AF0 File Offset: 0x0067FCF0
		public static IDisablePlayerAiControl GetRootAsIDisablePlayerAiControl(ByteBuffer _bb)
		{
			return IDisablePlayerAiControl.GetRootAsIDisablePlayerAiControl(_bb, default(IDisablePlayerAiControl));
		}

		// Token: 0x0602FC55 RID: 195669 RVA: 0x00681B0C File Offset: 0x0067FD0C
		public static IDisablePlayerAiControl GetRootAsIDisablePlayerAiControl(ByteBuffer _bb, IDisablePlayerAiControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC56 RID: 195670 RVA: 0x00681B29 File Offset: 0x0067FD29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC57 RID: 195671 RVA: 0x00681B38 File Offset: 0x0067FD38
		public IDisablePlayerAiControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB6F RID: 52079
		// (get) Token: 0x0602FC58 RID: 195672 RVA: 0x00681B48 File Offset: 0x0067FD48
		public EPlayerAiControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAiControlType.Enable;
				}
				return (EPlayerAiControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC59 RID: 195673 RVA: 0x00681B84 File Offset: 0x0067FD84
		public static Offset<IDisablePlayerAiControl> CreateIDisablePlayerAiControl(FlatBufferBuilder builder, EPlayerAiControlType Type = EPlayerAiControlType.Enable)
		{
			builder.StartTable(1);
			IDisablePlayerAiControl.AddType(builder, Type);
			return IDisablePlayerAiControl.EndIDisablePlayerAiControl(builder);
		}

		// Token: 0x0602FC5A RID: 195674 RVA: 0x00681B9A File Offset: 0x0067FD9A
		public static void StartIDisablePlayerAiControl(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FC5B RID: 195675 RVA: 0x00681BA3 File Offset: 0x0067FDA3
		public static void AddType(FlatBufferBuilder builder, EPlayerAiControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC5C RID: 195676 RVA: 0x00681BAE File Offset: 0x0067FDAE
		public static Offset<IDisablePlayerAiControl> EndIDisablePlayerAiControl(FlatBufferBuilder builder)
		{
			return new Offset<IDisablePlayerAiControl>(builder.EndTable());
		}

		// Token: 0x0602FC5D RID: 195677 RVA: 0x00681BBC File Offset: 0x0067FDBC
		public IDisablePlayerAiControlT UnPack()
		{
			IDisablePlayerAiControlT disablePlayerAiControlT = new IDisablePlayerAiControlT();
			this.UnPackTo(disablePlayerAiControlT);
			return disablePlayerAiControlT;
		}

		// Token: 0x0602FC5E RID: 195678 RVA: 0x00681BD7 File Offset: 0x0067FDD7
		public void UnPackTo(IDisablePlayerAiControlT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FC5F RID: 195679 RVA: 0x00681BE8 File Offset: 0x0067FDE8
		public static Offset<IDisablePlayerAiControl> Pack(FlatBufferBuilder builder, IDisablePlayerAiControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisablePlayerAiControl>);
			}
			return IDisablePlayerAiControl.CreateIDisablePlayerAiControl(builder, _o.Type);
		}

		// Token: 0x04011A82 RID: 72322
		private Table __p;
	}
}
