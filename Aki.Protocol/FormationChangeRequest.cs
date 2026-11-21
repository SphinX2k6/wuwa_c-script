using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000617 RID: 1559
	[NetMessage(EMessageId.FormationChangeRequest)]
	public sealed class FormationChangeRequest : IMessage<FormationChangeRequest>, IMessage, IEquatable<FormationChangeRequest>, IDeepCloneable<FormationChangeRequest>, IBufferMessage
	{
		// Token: 0x06009047 RID: 36935 RVA: 0x0015DB8D File Offset: 0x0015BD8D
		[NullableContext(1)]
		public static FormationChangeRequest Create()
		{
			return new FormationChangeRequest();
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x0015DB94 File Offset: 0x0015BD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06009049 RID: 36937 RVA: 0x0015DB97 File Offset: 0x0015BD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeRequest.Descriptor;
			}
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x0015DB9E File Offset: 0x0015BD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest()
		{
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x0015DBB1 File Offset: 0x0015BDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest(FormationChangeRequest other) : this()
		{
			this.changeList_ = other.changeList_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x0015DBE7 File Offset: 0x0015BDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeRequest Clone()
		{
			return new FormationChangeRequest(this);
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x0600904D RID: 36941 RVA: 0x0015DBEF File Offset: 0x0015BDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationChangeInfo> ChangeList
		{
			get
			{
				return this.changeList_;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x0600904E RID: 36942 RVA: 0x0015DBF7 File Offset: 0x0015BDF7
		// (set) Token: 0x0600904F RID: 36943 RVA: 0x0015DBFF File Offset: 0x0015BDFF
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

		// Token: 0x06009050 RID: 36944 RVA: 0x0015DC08 File Offset: 0x0015BE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeRequest);
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x0015DC18 File Offset: 0x0015BE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeRequest other)
		{
			return other != null && (other == this || (this.changeList_.Equals(other.changeList_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x0015DC68 File Offset: 0x0015BE68
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

		// Token: 0x06009053 RID: 36947 RVA: 0x0015DCB5 File Offset: 0x0015BEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x0015DCC2 File Offset: 0x0015BEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x0015DCCC File Offset: 0x0015BECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeList_.WriteTo(ref output, FormationChangeRequest._repeated_changeList_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x0015DD1C File Offset: 0x0015BF1C
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

		// Token: 0x06009057 RID: 36951 RVA: 0x0015DD70 File Offset: 0x0015BF70
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

		// Token: 0x06009058 RID: 36952 RVA: 0x0015DDBD File Offset: 0x0015BFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x0015DDC8 File Offset: 0x0015BFC8
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
					if (num != 24U)
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

		// Token: 0x0400464C RID: 17996
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400464D RID: 17997
		public const int ChangeListFieldNumber = 1;

		// Token: 0x0400464E RID: 17998
		private static readonly FieldCodec<FormationChangeInfo> _repeated_changeList_codec = FieldCodec.ForMessage<FormationChangeInfo>(10U, FormationChangeInfo.Parser);

		// Token: 0x0400464F RID: 17999
		private readonly RepeatedField<FormationChangeInfo> changeList_ = new RepeatedField<FormationChangeInfo>();

		// Token: 0x04004650 RID: 18000
		public const int FormationIdFieldNumber = 3;

		// Token: 0x04004651 RID: 18001
		private int formationId_;
	}
}
