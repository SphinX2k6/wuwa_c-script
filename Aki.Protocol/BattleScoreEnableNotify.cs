using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017B RID: 379
	[NetMessage(EMessageId.BattleScoreEnableNotify)]
	public sealed class BattleScoreEnableNotify : IMessage<BattleScoreEnableNotify>, IMessage, IEquatable<BattleScoreEnableNotify>, IDeepCloneable<BattleScoreEnableNotify>, IBufferMessage
	{
		// Token: 0x06002E21 RID: 11809 RVA: 0x00076EE5 File Offset: 0x000750E5
		[NullableContext(1)]
		public static BattleScoreEnableNotify Create()
		{
			return new BattleScoreEnableNotify();
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x00076EEC File Offset: 0x000750EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00076EEF File Offset: 0x000750EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleScoreEnableNotify.Descriptor;
			}
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00076EF6 File Offset: 0x000750F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify()
		{
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00076EFE File Offset: 0x000750FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify(BattleScoreEnableNotify other) : this()
		{
			this.battleScoreConfId_ = other.battleScoreConfId_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00076F2F File Offset: 0x0007512F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify Clone()
		{
			return new BattleScoreEnableNotify(this);
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00076F37 File Offset: 0x00075137
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x00076F3F File Offset: 0x0007513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleScoreConfId
		{
			get
			{
				return this.battleScoreConfId_;
			}
			set
			{
				this.battleScoreConfId_ = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00076F48 File Offset: 0x00075148
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x00076F50 File Offset: 0x00075150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00076F59 File Offset: 0x00075159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleScoreEnableNotify);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00076F67 File Offset: 0x00075167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleScoreEnableNotify other)
		{
			return other != null && (other == this || (this.BattleScoreConfId == other.BattleScoreConfId && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00076FA8 File Offset: 0x000751A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleScoreConfId != 0)
			{
				num ^= this.BattleScoreConfId.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00077000 File Offset: 0x00075200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0007700D File Offset: 0x0007520D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00077018 File Offset: 0x00075218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleScoreConfId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BattleScoreConfId);
			}
			if (this.Enable)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00077074 File Offset: 0x00075274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleScoreConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleScoreConfId);
			}
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000770C0 File Offset: 0x000752C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleScoreEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleScoreConfId != 0)
			{
				this.BattleScoreConfId = other.BattleScoreConfId;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00077110 File Offset: 0x00075310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x0007711C File Offset: 0x0007531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Enable = input.ReadBool();
					}
				}
				else
				{
					this.BattleScoreConfId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002861 RID: 10337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002862 RID: 10338
		public const int BattleScoreConfIdFieldNumber = 12;

		// Token: 0x04002863 RID: 10339
		private int battleScoreConfId_;

		// Token: 0x04002864 RID: 10340
		public const int EnableFieldNumber = 14;

		// Token: 0x04002865 RID: 10341
		private bool enable_;
	}
}
