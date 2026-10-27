using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD8 RID: 19160
	public struct ICheckPlayerCanJoinActivityCondition : IFlatbufferObject
	{
		// Token: 0x17008AEC RID: 35564
		// (get) Token: 0x0601E188 RID: 123272 RVA: 0x00438DE0 File Offset: 0x00436FE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E189 RID: 123273 RVA: 0x00438DED File Offset: 0x00436FED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E18A RID: 123274 RVA: 0x00438DF4 File Offset: 0x00436FF4
		public static ICheckPlayerCanJoinActivityCondition GetRootAsICheckPlayerCanJoinActivityCondition(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinActivityCondition.GetRootAsICheckPlayerCanJoinActivityCondition(_bb, default(ICheckPlayerCanJoinActivityCondition));
		}

		// Token: 0x0601E18B RID: 123275 RVA: 0x00438E10 File Offset: 0x00437010
		public static ICheckPlayerCanJoinActivityCondition GetRootAsICheckPlayerCanJoinActivityCondition(ByteBuffer _bb, ICheckPlayerCanJoinActivityCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E18C RID: 123276 RVA: 0x00438E2D File Offset: 0x0043702D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E18D RID: 123277 RVA: 0x00438E3C File Offset: 0x0043703C
		public ICheckPlayerCanJoinActivityCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AED RID: 35565
		// (get) Token: 0x0601E18E RID: 123278 RVA: 0x00438E4C File Offset: 0x0043704C
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

		// Token: 0x17008AEE RID: 35566
		// (get) Token: 0x0601E18F RID: 123279 RVA: 0x00438E88 File Offset: 0x00437088
		public ICheckPlayerCanJoinRogue? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPlayerCanJoinRogue?(default(ICheckPlayerCanJoinRogue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601E190 RID: 123280 RVA: 0x00438EE5 File Offset: 0x004370E5
		public static Offset<ICheckPlayerCanJoinActivityCondition> CreateICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICheckPlayerCanJoinRogue> ConfigOffset = default(Offset<ICheckPlayerCanJoinRogue>))
		{
			builder.StartTable(2);
			ICheckPlayerCanJoinActivityCondition.AddConfig(builder, ConfigOffset);
			ICheckPlayerCanJoinActivityCondition.AddType(builder, Type);
			return ICheckPlayerCanJoinActivityCondition.EndICheckPlayerCanJoinActivityCondition(builder);
		}

		// Token: 0x0601E191 RID: 123281 RVA: 0x00438F02 File Offset: 0x00437102
		public static void StartICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E192 RID: 123282 RVA: 0x00438F0B File Offset: 0x0043710B
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E193 RID: 123283 RVA: 0x00438F16 File Offset: 0x00437116
		public static void AddConfig(FlatBufferBuilder builder, Offset<ICheckPlayerCanJoinRogue> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0601E194 RID: 123284 RVA: 0x00438F26 File Offset: 0x00437126
		public static Offset<ICheckPlayerCanJoinActivityCondition> EndICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinActivityCondition>(builder.EndTable());
		}

		// Token: 0x0601E195 RID: 123285 RVA: 0x00438F34 File Offset: 0x00437134
		public ICheckPlayerCanJoinActivityConditionT UnPack()
		{
			ICheckPlayerCanJoinActivityConditionT checkPlayerCanJoinActivityConditionT = new ICheckPlayerCanJoinActivityConditionT();
			this.UnPackTo(checkPlayerCanJoinActivityConditionT);
			return checkPlayerCanJoinActivityConditionT;
		}

		// Token: 0x0601E196 RID: 123286 RVA: 0x00438F50 File Offset: 0x00437150
		public void UnPackTo(ICheckPlayerCanJoinActivityConditionT _o)
		{
			_o.Type = this.Type;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0601E197 RID: 123287 RVA: 0x00438F98 File Offset: 0x00437198
		public static Offset<ICheckPlayerCanJoinActivityCondition> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinActivityConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinActivityCondition>);
			}
			Offset<ICheckPlayerCanJoinRogue> configOffset = (_o.Config == null) ? default(Offset<ICheckPlayerCanJoinRogue>) : ICheckPlayerCanJoinRogue.Pack(builder, _o.Config);
			return ICheckPlayerCanJoinActivityCondition.CreateICheckPlayerCanJoinActivityCondition(builder, _o.Type, configOffset);
		}

		// Token: 0x0400D362 RID: 54114
		private Table __p;
	}
}
