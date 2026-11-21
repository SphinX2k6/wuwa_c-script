using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DA RID: 218
	[NetMessage(EMessageId.AgreeJoinResultRequest)]
	public sealed class AgreeJoinResultRequest : IMessage<AgreeJoinResultRequest>, IMessage, IEquatable<AgreeJoinResultRequest>, IDeepCloneable<AgreeJoinResultRequest>, IBufferMessage
	{
		// Token: 0x060020F4 RID: 8436 RVA: 0x00058B2C File Offset: 0x00056D2C
		[NullableContext(1)]
		public static AgreeJoinResultRequest Create()
		{
			return new AgreeJoinResultRequest();
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00058B33 File Offset: 0x00056D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x00058B36 File Offset: 0x00056D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultRequest.Descriptor;
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00058B3D File Offset: 0x00056D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00058B45 File Offset: 0x00056D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest(AgreeJoinResultRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00058B82 File Offset: 0x00056D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultRequest Clone()
		{
			return new AgreeJoinResultRequest(this);
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x00058B8A File Offset: 0x00056D8A
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x00058B92 File Offset: 0x00056D92
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x00058B9B File Offset: 0x00056D9B
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x00058BA3 File Offset: 0x00056DA3
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x00058BAC File Offset: 0x00056DAC
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x00058BB4 File Offset: 0x00056DB4
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

		// Token: 0x06002100 RID: 8448 RVA: 0x00058BBD File Offset: 0x00056DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultRequest);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00058BCC File Offset: 0x00056DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00058C28 File Offset: 0x00056E28
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

		// Token: 0x06002103 RID: 8451 RVA: 0x00058C9F File Offset: 0x00056E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00058CAC File Offset: 0x00056EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00058CB8 File Offset: 0x00056EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Way != AgreeJoinWay.ClientActive)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Way);
			}
			if (this.Result)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Result);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00058D30 File Offset: 0x00056F30
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

		// Token: 0x06002107 RID: 8455 RVA: 0x00058D94 File Offset: 0x00056F94
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

		// Token: 0x06002108 RID: 8456 RVA: 0x00058DF8 File Offset: 0x00056FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00058E04 File Offset: 0x00057004
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
				if (num != 48U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Way = (AgreeJoinWay)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002467 RID: 9319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002468 RID: 9320
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x04002469 RID: 9321
		private int playerId_;

		// Token: 0x0400246A RID: 9322
		public const int ResultFieldNumber = 13;

		// Token: 0x0400246B RID: 9323
		private bool result_;

		// Token: 0x0400246C RID: 9324
		public const int WayFieldNumber = 6;

		// Token: 0x0400246D RID: 9325
		private AgreeJoinWay way_;
	}
}
