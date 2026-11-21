using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004A RID: 74
	[NetMessage(EMessageId.AbyssShowNameRequest)]
	public sealed class AbyssShowNameRequest : IMessage<AbyssShowNameRequest>, IMessage, IEquatable<AbyssShowNameRequest>, IDeepCloneable<AbyssShowNameRequest>, IBufferMessage
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x00036D71 File Offset: 0x00034F71
		[NullableContext(1)]
		public static AbyssShowNameRequest Create()
		{
			return new AbyssShowNameRequest();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00036D78 File Offset: 0x00034F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x00036D7B File Offset: 0x00034F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssShowNameRequest.Descriptor;
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00036D82 File Offset: 0x00034F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest()
		{
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00036D8A File Offset: 0x00034F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest(AbyssShowNameRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00036DBB File Offset: 0x00034FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest Clone()
		{
			return new AbyssShowNameRequest(this);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00036DC3 File Offset: 0x00034FC3
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x00036DCB File Offset: 0x00034FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00036DD4 File Offset: 0x00034FD4
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00036DDC File Offset: 0x00034FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00036DE5 File Offset: 0x00034FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssShowNameRequest);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00036DF3 File Offset: 0x00034FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssShowNameRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00036E34 File Offset: 0x00035034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00036E8C File Offset: 0x0003508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00036E99 File Offset: 0x00035099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00036EA4 File Offset: 0x000350A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowName)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowName);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00036F00 File Offset: 0x00035100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00036F4C File Offset: 0x0003514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssShowNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00036F9C File Offset: 0x0003519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00036FA8 File Offset: 0x000351A8
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
				if (num != 16U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeId = input.ReadInt32();
					}
				}
				else
				{
					this.ShowName = input.ReadBool();
				}
			}
		}

		// Token: 0x040020A4 RID: 8356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A5 RID: 8357
		public const int ChallengeIdFieldNumber = 14;

		// Token: 0x040020A6 RID: 8358
		private int challengeId_;

		// Token: 0x040020A7 RID: 8359
		public const int ShowNameFieldNumber = 2;

		// Token: 0x040020A8 RID: 8360
		private bool showName_;
	}
}
