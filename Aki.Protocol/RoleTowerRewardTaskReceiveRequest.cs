using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DF RID: 4319
	[NetMessage(EMessageId.RoleTowerRewardTaskReceiveRequest)]
	public sealed class RoleTowerRewardTaskReceiveRequest : IMessage<RoleTowerRewardTaskReceiveRequest>, IMessage, IEquatable<RoleTowerRewardTaskReceiveRequest>, IDeepCloneable<RoleTowerRewardTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x06017178 RID: 94584 RVA: 0x0035C364 File Offset: 0x0035A564
		[NullableContext(1)]
		public static RoleTowerRewardTaskReceiveRequest Create()
		{
			return new RoleTowerRewardTaskReceiveRequest();
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x06017179 RID: 94585 RVA: 0x0035C36B File Offset: 0x0035A56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x0601717A RID: 94586 RVA: 0x0035C36E File Offset: 0x0035A56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRewardTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0601717B RID: 94587 RVA: 0x0035C375 File Offset: 0x0035A575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveRequest()
		{
		}

		// Token: 0x0601717C RID: 94588 RVA: 0x0035C388 File Offset: 0x0035A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveRequest(RoleTowerRewardTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601717D RID: 94589 RVA: 0x0035C3B2 File Offset: 0x0035A5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveRequest Clone()
		{
			return new RoleTowerRewardTaskReceiveRequest(this);
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x0601717E RID: 94590 RVA: 0x0035C3BA File Offset: 0x0035A5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601717F RID: 94591 RVA: 0x0035C3C2 File Offset: 0x0035A5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRewardTaskReceiveRequest);
		}

		// Token: 0x06017180 RID: 94592 RVA: 0x0035C3D0 File Offset: 0x0035A5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRewardTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017181 RID: 94593 RVA: 0x0035C404 File Offset: 0x0035A604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017182 RID: 94594 RVA: 0x0035C438 File Offset: 0x0035A638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017183 RID: 94595 RVA: 0x0035C445 File Offset: 0x0035A645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017184 RID: 94596 RVA: 0x0035C44E File Offset: 0x0035A64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoleTowerRewardTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017185 RID: 94597 RVA: 0x0035C478 File Offset: 0x0035A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RoleTowerRewardTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017186 RID: 94598 RVA: 0x0035C4B1 File Offset: 0x0035A6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRewardTaskReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017187 RID: 94599 RVA: 0x0035C4DF File Offset: 0x0035A6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017188 RID: 94600 RVA: 0x0035C4E8 File Offset: 0x0035A6E8
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RoleTowerRewardTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04008A3F RID: 35391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A40 RID: 35392
		public const int TaskIdsFieldNumber = 5;

		// Token: 0x04008A41 RID: 35393
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008A42 RID: 35394
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
