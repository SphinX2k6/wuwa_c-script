using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062B RID: 1579
	[NetMessage(EMessageId.FormationChangeRequest)]
	public sealed class FormationChangeRequest : IMessage<FormationChangeRequest>, IMessage, IEquatable<FormationChangeRequest>, IDeepCloneable<FormationChangeRequest>, IBufferMessage
	{
		// Token: 0x0600919D RID: 37277 RVA: 0x001605BD File Offset: 0x0015E7BD
		[NullableContext(1)]
		public static FormationChangeRequest Create()
		{
			return new FormationChangeRequest();
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x001605C4 File Offset: 0x0015E7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600919F RID: 37279 RVA: 0x001605C7 File Offset: 0x0015E7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeRequest.Descriptor;
			}
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x001605CE File Offset: 0x0015E7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest()
		{
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x001605E1 File Offset: 0x0015E7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest(FormationChangeRequest other) : this()
		{
			this.changeList_ = other.changeList_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x00160617 File Offset: 0x0015E817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest Clone()
		{
			return new FormationChangeRequest(this);
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x0016061F File Offset: 0x0015E81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationChangeInfo> ChangeList
		{
			get
			{
				return this.changeList_;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00160627 File Offset: 0x0015E827
		// (set) Token: 0x060091A5 RID: 37285 RVA: 0x0016062F File Offset: 0x0015E82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x00160638 File Offset: 0x0015E838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeRequest);
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x00160648 File Offset: 0x0015E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeRequest other)
		{
			return other != null && (other == this || (this.changeList_.Equals(other.changeList_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091A8 RID: 37288 RVA: 0x00160698 File Offset: 0x0015E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.changeList_.GetHashCode();
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x001606E5 File Offset: 0x0015E8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x001606F2 File Offset: 0x0015E8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x001606FC File Offset: 0x0015E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeList_.WriteTo(ref output, FormationChangeRequest._repeated_changeList_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x0016074C File Offset: 0x0015E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.changeList_.CalculateSize(FormationChangeRequest._repeated_changeList_codec);
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x001607A0 File Offset: 0x0015E9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.changeList_.Add(other.changeList_);
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x001607ED File Offset: 0x0015E9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x001607F8 File Offset: 0x0015E9F8
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
				if (num != 10U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FormationId = input.ReadInt32();
					}
				}
				else
				{
					this.changeList_.AddEntriesFrom(ref input, FormationChangeRequest._repeated_changeList_codec);
				}
			}
		}

		// Token: 0x04004653 RID: 18003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004654 RID: 18004
		public const int ChangeListFieldNumber = 1;

		// Token: 0x04004655 RID: 18005
		private static readonly FieldCodec<FormationChangeInfo> _repeated_changeList_codec = FieldCodec.ForMessage<FormationChangeInfo>(10U, FormationChangeInfo.Parser);

		// Token: 0x04004656 RID: 18006
		private readonly RepeatedField<FormationChangeInfo> changeList_ = new RepeatedField<FormationChangeInfo>();

		// Token: 0x04004657 RID: 18007
		public const int FormationIdFieldNumber = 12;

		// Token: 0x04004658 RID: 18008
		private int formationId_;
	}
}
