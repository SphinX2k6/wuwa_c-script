using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC9 RID: 3785
	[NetMessage(EMessageId.RegressBonusRequest)]
	public sealed class RegressBonusRequest : IMessage<RegressBonusRequest>, IMessage, IEquatable<RegressBonusRequest>, IDeepCloneable<RegressBonusRequest>, IBufferMessage
	{
		// Token: 0x06014512 RID: 83218 RVA: 0x002F45AF File Offset: 0x002F27AF
		[NullableContext(1)]
		public static RegressBonusRequest Create()
		{
			return new RegressBonusRequest();
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x06014513 RID: 83219 RVA: 0x002F45B6 File Offset: 0x002F27B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x06014514 RID: 83220 RVA: 0x002F45B9 File Offset: 0x002F27B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusRequest.Descriptor;
			}
		}

		// Token: 0x06014515 RID: 83221 RVA: 0x002F45C0 File Offset: 0x002F27C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest()
		{
		}

		// Token: 0x06014516 RID: 83222 RVA: 0x002F45D3 File Offset: 0x002F27D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest(RegressBonusRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014517 RID: 83223 RVA: 0x002F4609 File Offset: 0x002F2809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest Clone()
		{
			return new RegressBonusRequest(this);
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x06014518 RID: 83224 RVA: 0x002F4611 File Offset: 0x002F2811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x06014519 RID: 83225 RVA: 0x002F4619 File Offset: 0x002F2819
		// (set) Token: 0x0601451A RID: 83226 RVA: 0x002F4621 File Offset: 0x002F2821
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

		// Token: 0x0601451B RID: 83227 RVA: 0x002F462A File Offset: 0x002F282A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusRequest);
		}

		// Token: 0x0601451C RID: 83228 RVA: 0x002F4638 File Offset: 0x002F2838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601451D RID: 83229 RVA: 0x002F4688 File Offset: 0x002F2888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601451E RID: 83230 RVA: 0x002F46D5 File Offset: 0x002F28D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601451F RID: 83231 RVA: 0x002F46E2 File Offset: 0x002F28E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014520 RID: 83232 RVA: 0x002F46EC File Offset: 0x002F28EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, RegressBonusRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014521 RID: 83233 RVA: 0x002F473C File Offset: 0x002F293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(RegressBonusRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014522 RID: 83234 RVA: 0x002F4790 File Offset: 0x002F2990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBonusRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014523 RID: 83235 RVA: 0x002F47DD File Offset: 0x002F29DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014524 RID: 83236 RVA: 0x002F47E8 File Offset: 0x002F29E8
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
				if (num != 40U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, RegressBonusRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BD0 RID: 31696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BD1 RID: 31697
		public const int IdsFieldNumber = 8;

		// Token: 0x04007BD2 RID: 31698
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007BD3 RID: 31699
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04007BD4 RID: 31700
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04007BD5 RID: 31701
		private int activityId_;
	}
}
