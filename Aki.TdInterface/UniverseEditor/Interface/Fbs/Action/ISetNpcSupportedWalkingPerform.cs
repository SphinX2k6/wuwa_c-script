using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007040 RID: 28736
	public struct ISetNpcSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700D566 RID: 54630
		// (get) Token: 0x06032D6C RID: 208236 RVA: 0x006DB7FB File Offset: 0x006D99FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D6D RID: 208237 RVA: 0x006DB808 File Offset: 0x006D9A08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D6E RID: 208238 RVA: 0x006DB810 File Offset: 0x006D9A10
		public static ISetNpcSupportedWalkingPerform GetRootAsISetNpcSupportedWalkingPerform(ByteBuffer _bb)
		{
			return ISetNpcSupportedWalkingPerform.GetRootAsISetNpcSupportedWalkingPerform(_bb, default(ISetNpcSupportedWalkingPerform));
		}

		// Token: 0x06032D6F RID: 208239 RVA: 0x006DB82C File Offset: 0x006D9A2C
		public static ISetNpcSupportedWalkingPerform GetRootAsISetNpcSupportedWalkingPerform(ByteBuffer _bb, ISetNpcSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D70 RID: 208240 RVA: 0x006DB849 File Offset: 0x006D9A49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D71 RID: 208241 RVA: 0x006DB858 File Offset: 0x006D9A58
		public ISetNpcSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D567 RID: 54631
		// (get) Token: 0x06032D72 RID: 208242 RVA: 0x006DB868 File Offset: 0x006D9A68
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D568 RID: 54632
		// (get) Token: 0x06032D73 RID: 208243 RVA: 0x006DB8A4 File Offset: 0x006D9AA4
		public IPlayerInitiator? Initiator
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerInitiator?(default(IPlayerInitiator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D569 RID: 54633
		// (get) Token: 0x06032D74 RID: 208244 RVA: 0x006DB904 File Offset: 0x006D9B04
		public int Target
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D75 RID: 208245 RVA: 0x006DB940 File Offset: 0x006D9B40
		public static Offset<ISetNpcSupportedWalkingPerform> CreateISetNpcSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0)
		{
			builder.StartTable(3);
			ISetNpcSupportedWalkingPerform.AddTarget(builder, Target);
			ISetNpcSupportedWalkingPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcSupportedWalkingPerform.AddType(builder, Type);
			return ISetNpcSupportedWalkingPerform.EndISetNpcSupportedWalkingPerform(builder);
		}

		// Token: 0x06032D76 RID: 208246 RVA: 0x006DB964 File Offset: 0x006D9B64
		public static void StartISetNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032D77 RID: 208247 RVA: 0x006DB96D File Offset: 0x006D9B6D
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D78 RID: 208248 RVA: 0x006DB978 File Offset: 0x006D9B78
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06032D79 RID: 208249 RVA: 0x006DB988 File Offset: 0x006D9B88
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06032D7A RID: 208250 RVA: 0x006DB993 File Offset: 0x006D9B93
		public static Offset<ISetNpcSupportedWalkingPerform> EndISetNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x06032D7B RID: 208251 RVA: 0x006DB9A0 File Offset: 0x006D9BA0
		public ISetNpcSupportedWalkingPerformT UnPack()
		{
			ISetNpcSupportedWalkingPerformT setNpcSupportedWalkingPerformT = new ISetNpcSupportedWalkingPerformT();
			this.UnPackTo(setNpcSupportedWalkingPerformT);
			return setNpcSupportedWalkingPerformT;
		}

		// Token: 0x06032D7C RID: 208252 RVA: 0x006DB9BC File Offset: 0x006D9BBC
		public void UnPackTo(ISetNpcSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
		}

		// Token: 0x06032D7D RID: 208253 RVA: 0x006DBA10 File Offset: 0x006D9C10
		public static Offset<ISetNpcSupportedWalkingPerform> Pack(FlatBufferBuilder builder, ISetNpcSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcSupportedWalkingPerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcSupportedWalkingPerform.CreateISetNpcSupportedWalkingPerform(builder, _o.Type, initiatorOffset, _o.Target);
		}

		// Token: 0x04011A7C RID: 72316
		private Table __p;
	}
}
