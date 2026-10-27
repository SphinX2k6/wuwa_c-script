using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004214 RID: 16916
	public struct ITrackRuleTypeBase : IFlatbufferObject
	{
		// Token: 0x1700782A RID: 30762
		// (get) Token: 0x06018FF9 RID: 102393 RVA: 0x00398F95 File Offset: 0x00397195
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018FFA RID: 102394 RVA: 0x00398FA2 File Offset: 0x003971A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018FFB RID: 102395 RVA: 0x00398FAC File Offset: 0x003971AC
		public static ITrackRuleTypeBase GetRootAsITrackRuleTypeBase(ByteBuffer _bb)
		{
			return ITrackRuleTypeBase.GetRootAsITrackRuleTypeBase(_bb, default(ITrackRuleTypeBase));
		}

		// Token: 0x06018FFC RID: 102396 RVA: 0x00398FC8 File Offset: 0x003971C8
		public static ITrackRuleTypeBase GetRootAsITrackRuleTypeBase(ByteBuffer _bb, ITrackRuleTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018FFD RID: 102397 RVA: 0x00398FE5 File Offset: 0x003971E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018FFE RID: 102398 RVA: 0x00398FF4 File Offset: 0x003971F4
		public ITrackRuleTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700782B RID: 30763
		// (get) Token: 0x06018FFF RID: 102399 RVA: 0x00399004 File Offset: 0x00397204
		public ETrackRuleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackRuleType.FindLastMatchState;
				}
				return (ETrackRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019000 RID: 102400 RVA: 0x00399040 File Offset: 0x00397240
		public static Offset<ITrackRuleTypeBase> CreateITrackRuleTypeBase(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState)
		{
			builder.StartTable(1);
			ITrackRuleTypeBase.AddType(builder, Type);
			return ITrackRuleTypeBase.EndITrackRuleTypeBase(builder);
		}

		// Token: 0x06019001 RID: 102401 RVA: 0x00399056 File Offset: 0x00397256
		public static void StartITrackRuleTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019002 RID: 102402 RVA: 0x0039905F File Offset: 0x0039725F
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x0039906A File Offset: 0x0039726A
		public static Offset<ITrackRuleTypeBase> EndITrackRuleTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleTypeBase>(builder.EndTable());
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x00399078 File Offset: 0x00397278
		public ITrackRuleTypeBaseT UnPack()
		{
			ITrackRuleTypeBaseT trackRuleTypeBaseT = new ITrackRuleTypeBaseT();
			this.UnPackTo(trackRuleTypeBaseT);
			return trackRuleTypeBaseT;
		}

		// Token: 0x06019005 RID: 102405 RVA: 0x00399093 File Offset: 0x00397293
		public void UnPackTo(ITrackRuleTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019006 RID: 102406 RVA: 0x003990A4 File Offset: 0x003972A4
		public static Offset<ITrackRuleTypeBase> Pack(FlatBufferBuilder builder, ITrackRuleTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleTypeBase>);
			}
			return ITrackRuleTypeBase.CreateITrackRuleTypeBase(builder, _o.Type);
		}

		// Token: 0x0400BE85 RID: 48773
		private Table __p;
	}
}
