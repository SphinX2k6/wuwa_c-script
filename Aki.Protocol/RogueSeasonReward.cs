using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001016 RID: 4118
	public sealed class RogueSeasonReward : IMessage<RogueSeasonReward>, IMessage, IEquatable<RogueSeasonReward>, IDeepCloneable<RogueSeasonReward>, IBufferMessage
	{
		// Token: 0x06016050 RID: 90192 RVA: 0x0033391C File Offset: 0x00331B1C
		[NullableContext(1)]
		public static RogueSeasonReward Create()
		{
			return new RogueSeasonReward();
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x06016051 RID: 90193 RVA: 0x00333923 File Offset: 0x00331B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueSeasonReward> Parser
		{
			get
			{
				return RogueSeasonReward._parser;
			}
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x06016052 RID: 90194 RVA: 0x0033392A File Offset: 0x00331B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x06016053 RID: 90195 RVA: 0x0033392D File Offset: 0x00331B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSeasonReward.Descriptor;
			}
		}

		// Token: 0x06016054 RID: 90196 RVA: 0x00333934 File Offset: 0x00331B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward()
		{
		}

		// Token: 0x06016055 RID: 90197 RVA: 0x0033393C File Offset: 0x00331B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward(RogueSeasonReward other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016056 RID: 90198 RVA: 0x0033396D File Offset: 0x00331B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward Clone()
		{
			return new RogueSeasonReward(this);
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x06016057 RID: 90199 RVA: 0x00333975 File Offset: 0x00331B75
		// (set) Token: 0x06016058 RID: 90200 RVA: 0x0033397D File Offset: 0x00331B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x06016059 RID: 90201 RVA: 0x00333986 File Offset: 0x00331B86
		// (set) Token: 0x0601605A RID: 90202 RVA: 0x0033398E File Offset: 0x00331B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x0601605B RID: 90203 RVA: 0x00333997 File Offset: 0x00331B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSeasonReward);
		}

		// Token: 0x0601605C RID: 90204 RVA: 0x003339A5 File Offset: 0x00331BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSeasonReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601605D RID: 90205 RVA: 0x003339E4 File Offset: 0x00331BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601605E RID: 90206 RVA: 0x00333A3C File Offset: 0x00331C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601605F RID: 90207 RVA: 0x00333A49 File Offset: 0x00331C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016060 RID: 90208 RVA: 0x00333A54 File Offset: 0x00331C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReceive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016061 RID: 90209 RVA: 0x00333AAC File Offset: 0x00331CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016062 RID: 90210 RVA: 0x00333AF8 File Offset: 0x00331CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueSeasonReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016063 RID: 90211 RVA: 0x00333B48 File Offset: 0x00331D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016064 RID: 90212 RVA: 0x00333B54 File Offset: 0x00331D54
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsReceive = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008416 RID: 33814
		private static readonly MessageParser<RogueSeasonReward> _parser = new MessageParser<RogueSeasonReward>(() => new RogueSeasonReward());

		// Token: 0x04008417 RID: 33815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008418 RID: 33816
		public const int IdFieldNumber = 1;

		// Token: 0x04008419 RID: 33817
		private int id_;

		// Token: 0x0400841A RID: 33818
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x0400841B RID: 33819
		private bool isReceive_;
	}
}
