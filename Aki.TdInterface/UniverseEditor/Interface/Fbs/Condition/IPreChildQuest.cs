using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C8E RID: 19598
	public struct IPreChildQuest : IFlatbufferObject
	{
		// Token: 0x17008E4B RID: 36427
		// (get) Token: 0x0601F14F RID: 127311 RVA: 0x00457E79 File Offset: 0x00456079
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F150 RID: 127312 RVA: 0x00457E86 File Offset: 0x00456086
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F151 RID: 127313 RVA: 0x00457E90 File Offset: 0x00456090
		public static IPreChildQuest GetRootAsIPreChildQuest(ByteBuffer _bb)
		{
			return IPreChildQuest.GetRootAsIPreChildQuest(_bb, default(IPreChildQuest));
		}

		// Token: 0x0601F152 RID: 127314 RVA: 0x00457EAC File Offset: 0x004560AC
		public static IPreChildQuest GetRootAsIPreChildQuest(ByteBuffer _bb, IPreChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F153 RID: 127315 RVA: 0x00457EC9 File Offset: 0x004560C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F154 RID: 127316 RVA: 0x00457ED8 File Offset: 0x004560D8
		public IPreChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E4C RID: 36428
		// (get) Token: 0x0601F155 RID: 127317 RVA: 0x00457EE8 File Offset: 0x004560E8
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E4D RID: 36429
		// (get) Token: 0x0601F156 RID: 127318 RVA: 0x00457F24 File Offset: 0x00456124
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E4E RID: 36430
		// (get) Token: 0x0601F157 RID: 127319 RVA: 0x00457F60 File Offset: 0x00456160
		public IChildQuestCondition? PreChildQuest
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IChildQuestCondition?(default(IChildQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F158 RID: 127320 RVA: 0x00457FBD File Offset: 0x004561BD
		public static Offset<IPreChildQuest> CreateIPreChildQuest(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, Offset<IChildQuestCondition> PreChildQuestOffset = default(Offset<IChildQuestCondition>))
		{
			builder.StartTable(3);
			IPreChildQuest.AddPreChildQuest(builder, PreChildQuestOffset);
			IPreChildQuest.AddCompare(builder, Compare);
			IPreChildQuest.AddType(builder, Type);
			return IPreChildQuest.EndIPreChildQuest(builder);
		}

		// Token: 0x0601F159 RID: 127321 RVA: 0x00457FE1 File Offset: 0x004561E1
		public static void StartIPreChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F15A RID: 127322 RVA: 0x00457FEA File Offset: 0x004561EA
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F15B RID: 127323 RVA: 0x00457FF5 File Offset: 0x004561F5
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F15C RID: 127324 RVA: 0x00458000 File Offset: 0x00456200
		public static void AddPreChildQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> preChildQuestOffset)
		{
			builder.AddOffset(2, preChildQuestOffset.Value, 0);
		}

		// Token: 0x0601F15D RID: 127325 RVA: 0x00458010 File Offset: 0x00456210
		public static Offset<IPreChildQuest> EndIPreChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<IPreChildQuest>(builder.EndTable());
		}

		// Token: 0x0601F15E RID: 127326 RVA: 0x00458020 File Offset: 0x00456220
		public IPreChildQuestT UnPack()
		{
			IPreChildQuestT preChildQuestT = new IPreChildQuestT();
			this.UnPackTo(preChildQuestT);
			return preChildQuestT;
		}

		// Token: 0x0601F15F RID: 127327 RVA: 0x0045803C File Offset: 0x0045623C
		public void UnPackTo(IPreChildQuestT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PreChildQuest = ((this.PreChildQuest != null) ? this.PreChildQuest.Value.UnPack() : null);
		}

		// Token: 0x0601F160 RID: 127328 RVA: 0x00458090 File Offset: 0x00456290
		public static Offset<IPreChildQuest> Pack(FlatBufferBuilder builder, IPreChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreChildQuest>);
			}
			Offset<IChildQuestCondition> preChildQuestOffset = (_o.PreChildQuest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.PreChildQuest);
			return IPreChildQuest.CreateIPreChildQuest(builder, _o.Type, _o.Compare, preChildQuestOffset);
		}

		// Token: 0x0400D647 RID: 54855
		private Table __p;
	}
}
