using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050F RID: 1295
	[NetMessage(EMessageId.FarmGoldLevelPlayRequest)]
	public sealed class FarmGoldLevelPlayRequest : IMessage<FarmGoldLevelPlayRequest>, IMessage, IEquatable<FarmGoldLevelPlayRequest>, IDeepCloneable<FarmGoldLevelPlayRequest>, IBufferMessage
	{
		// Token: 0x06007A18 RID: 31256 RVA: 0x00128D84 File Offset: 0x00126F84
		[NullableContext(1)]
		public static FarmGoldLevelPlayRequest Create()
		{
			return new FarmGoldLevelPlayRequest();
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x00128D8B File Offset: 0x00126F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007A1A RID: 31258 RVA: 0x00128D8E File Offset: 0x00126F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRequest.Descriptor;
			}
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x00128D95 File Offset: 0x00126F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest()
		{
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x00128D9D File Offset: 0x00126F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest(FarmGoldLevelPlayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x00128DCE File Offset: 0x00126FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest Clone()
		{
			return new FarmGoldLevelPlayRequest(this);
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007A1E RID: 31262 RVA: 0x00128DD6 File Offset: 0x00126FD6
		// (set) Token: 0x06007A1F RID: 31263 RVA: 0x00128DDE File Offset: 0x00126FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x00128DE7 File Offset: 0x00126FE7
		// (set) Token: 0x06007A21 RID: 31265 RVA: 0x00128DEF File Offset: 0x00126FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x00128DF8 File Offset: 0x00126FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRequest);
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x00128E06 File Offset: 0x00127006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x00128E44 File Offset: 0x00127044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x00128E9C File Offset: 0x0012709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x00128EA9 File Offset: 0x001270A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x00128EB4 File Offset: 0x001270B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00128F10 File Offset: 0x00127110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x00128F68 File Offset: 0x00127168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00128FB8 File Offset: 0x001271B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x00128FC4 File Offset: 0x001271C4
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F29 RID: 16169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F2A RID: 16170
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04003F2B RID: 16171
		private int activityId_;

		// Token: 0x04003F2C RID: 16172
		public const int InstIdFieldNumber = 13;

		// Token: 0x04003F2D RID: 16173
		private int instId_;
	}
}
