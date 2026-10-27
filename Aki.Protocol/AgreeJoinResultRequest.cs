using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D9 RID: 217
	[NetMessage(EMessageId.AgreeJoinResultRequest)]
	public sealed class AgreeJoinResultRequest : IMessage<AgreeJoinResultRequest>, IMessage, IEquatable<AgreeJoinResultRequest>, IDeepCloneable<AgreeJoinResultRequest>, IBufferMessage
	{
		// Token: 0x060020AB RID: 8363 RVA: 0x00057E78 File Offset: 0x00056078
		[NullableContext(1)]
		public static AgreeJoinResultRequest Create()
		{
			return new AgreeJoinResultRequest();
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00057E7F File Offset: 0x0005607F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00057E82 File Offset: 0x00056082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultRequest.Descriptor;
			}
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00057E89 File Offset: 0x00056089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest()
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00057E91 File Offset: 0x00056091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest(AgreeJoinResultRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00057ECE File Offset: 0x000560CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest Clone()
		{
			return new AgreeJoinResultRequest(this);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00057ED6 File Offset: 0x000560D6
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00057EDE File Offset: 0x000560DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00057EE7 File Offset: 0x000560E7
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00057EEF File Offset: 0x000560EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00057EF8 File Offset: 0x000560F8
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00057F00 File Offset: 0x00056100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinWay Way
		{
			get
			{
				return this.way_;
			}
			set
			{
				this.way_ = value;
			}
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00057F09 File Offset: 0x00056109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultRequest);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00057F18 File Offset: 0x00056118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00057F74 File Offset: 0x00056174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Result)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.Way != AgreeJoinWay.ClientActive)
			{
				num ^= this.Way.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00057FEB File Offset: 0x000561EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00057FF8 File Offset: 0x000561F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00058004 File Offset: 0x00056204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Result);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Way != AgreeJoinWay.ClientActive)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0005807C File Offset: 0x0005627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Result)
			{
				num += 2;
			}
			if (this.Way != AgreeJoinWay.ClientActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000580E0 File Offset: 0x000562E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AgreeJoinResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Result)
			{
				this.Result = other.Result;
			}
			if (other.Way != AgreeJoinWay.ClientActive)
			{
				this.Way = other.Way;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00058144 File Offset: 0x00056344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00058150 File Offset: 0x00056350
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Way = (AgreeJoinWay)input.ReadEnum();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Result = input.ReadBool();
				}
			}
		}

		// Token: 0x04002404 RID: 9220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002405 RID: 9221
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04002406 RID: 9222
		private int playerId_;

		// Token: 0x04002407 RID: 9223
		public const int ResultFieldNumber = 3;

		// Token: 0x04002408 RID: 9224
		private bool result_;

		// Token: 0x04002409 RID: 9225
		public const int WayFieldNumber = 6;

		// Token: 0x0400240A RID: 9226
		private AgreeJoinWay way_;
	}
}
