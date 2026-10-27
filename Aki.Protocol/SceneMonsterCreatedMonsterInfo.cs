using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001182 RID: 4482
	public sealed class SceneMonsterCreatedMonsterInfo : IMessage<SceneMonsterCreatedMonsterInfo>, IMessage, IEquatable<SceneMonsterCreatedMonsterInfo>, IDeepCloneable<SceneMonsterCreatedMonsterInfo>, IBufferMessage
	{
		// Token: 0x06017E21 RID: 97825 RVA: 0x00377A19 File Offset: 0x00375C19
		[NullableContext(1)]
		public static SceneMonsterCreatedMonsterInfo Create()
		{
			return new SceneMonsterCreatedMonsterInfo();
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x06017E22 RID: 97826 RVA: 0x00377A20 File Offset: 0x00375C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMonsterCreatedMonsterInfo> Parser
		{
			get
			{
				return SceneMonsterCreatedMonsterInfo._parser;
			}
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x06017E23 RID: 97827 RVA: 0x00377A27 File Offset: 0x00375C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x06017E24 RID: 97828 RVA: 0x00377A2A File Offset: 0x00375C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterCreatedMonsterInfo.Descriptor;
			}
		}

		// Token: 0x06017E25 RID: 97829 RVA: 0x00377A31 File Offset: 0x00375C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo()
		{
		}

		// Token: 0x06017E26 RID: 97830 RVA: 0x00377A3C File Offset: 0x00375C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo(SceneMonsterCreatedMonsterInfo other) : this()
		{
			this.prefabId_ = other.prefabId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.baseLife_ = other.baseLife_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E27 RID: 97831 RVA: 0x00377A90 File Offset: 0x00375C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo Clone()
		{
			return new SceneMonsterCreatedMonsterInfo(this);
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x06017E28 RID: 97832 RVA: 0x00377A98 File Offset: 0x00375C98
		// (set) Token: 0x06017E29 RID: 97833 RVA: 0x00377AA0 File Offset: 0x00375CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PrefabId
		{
			get
			{
				return this.prefabId_;
			}
			set
			{
				this.prefabId_ = value;
			}
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x06017E2A RID: 97834 RVA: 0x00377AA9 File Offset: 0x00375CA9
		// (set) Token: 0x06017E2B RID: 97835 RVA: 0x00377AB1 File Offset: 0x00375CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x06017E2C RID: 97836 RVA: 0x00377ABA File Offset: 0x00375CBA
		// (set) Token: 0x06017E2D RID: 97837 RVA: 0x00377AC2 File Offset: 0x00375CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BaseLife
		{
			get
			{
				return this.baseLife_;
			}
			set
			{
				this.baseLife_ = value;
			}
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x06017E2E RID: 97838 RVA: 0x00377ACB File Offset: 0x00375CCB
		// (set) Token: 0x06017E2F RID: 97839 RVA: 0x00377AD3 File Offset: 0x00375CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06017E30 RID: 97840 RVA: 0x00377ADC File Offset: 0x00375CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterCreatedMonsterInfo);
		}

		// Token: 0x06017E31 RID: 97841 RVA: 0x00377AEC File Offset: 0x00375CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterCreatedMonsterInfo other)
		{
			return other != null && (other == this || (this.PrefabId == other.PrefabId && this.EntityConfigId == other.EntityConfigId && this.BaseLife == other.BaseLife && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E32 RID: 97842 RVA: 0x00377B58 File Offset: 0x00375D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PrefabId != 0)
			{
				num ^= this.PrefabId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.BaseLife != 0L)
			{
				num ^= this.BaseLife.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E33 RID: 97843 RVA: 0x00377BE2 File Offset: 0x00375DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E34 RID: 97844 RVA: 0x00377BEF File Offset: 0x00375DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E35 RID: 97845 RVA: 0x00377BF8 File Offset: 0x00375DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PrefabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PrefabId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.BaseLife != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BaseLife);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E36 RID: 97846 RVA: 0x00377C88 File Offset: 0x00375E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PrefabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PrefabId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.BaseLife != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BaseLife);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E37 RID: 97847 RVA: 0x00377D10 File Offset: 0x00375F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonsterCreatedMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PrefabId != 0)
			{
				this.PrefabId = other.PrefabId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.BaseLife != 0L)
			{
				this.BaseLife = other.BaseLife;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E38 RID: 97848 RVA: 0x00377D88 File Offset: 0x00375F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E39 RID: 97849 RVA: 0x00377D94 File Offset: 0x00375F94
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PrefabId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BaseLife = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D75 RID: 36213
		private static readonly MessageParser<SceneMonsterCreatedMonsterInfo> _parser = new MessageParser<SceneMonsterCreatedMonsterInfo>(() => new SceneMonsterCreatedMonsterInfo());

		// Token: 0x04008D76 RID: 36214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D77 RID: 36215
		public const int PrefabIdFieldNumber = 1;

		// Token: 0x04008D78 RID: 36216
		private int prefabId_;

		// Token: 0x04008D79 RID: 36217
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x04008D7A RID: 36218
		private int entityConfigId_;

		// Token: 0x04008D7B RID: 36219
		public const int BaseLifeFieldNumber = 3;

		// Token: 0x04008D7C RID: 36220
		private long baseLife_;

		// Token: 0x04008D7D RID: 36221
		public const int StateFieldNumber = 4;

		// Token: 0x04008D7E RID: 36222
		private int state_;
	}
}
