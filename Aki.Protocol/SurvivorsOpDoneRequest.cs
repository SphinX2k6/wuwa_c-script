using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001347 RID: 4935
	[NetMessage(EMessageId.SurvivorsOpDoneRequest)]
	public sealed class SurvivorsOpDoneRequest : IMessage<SurvivorsOpDoneRequest>, IMessage, IEquatable<SurvivorsOpDoneRequest>, IDeepCloneable<SurvivorsOpDoneRequest>, IBufferMessage
	{
		// Token: 0x0601A4D5 RID: 107733 RVA: 0x003D5A6B File Offset: 0x003D3C6B
		[NullableContext(1)]
		public static SurvivorsOpDoneRequest Create()
		{
			return new SurvivorsOpDoneRequest();
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x0601A4D6 RID: 107734 RVA: 0x003D5A72 File Offset: 0x003D3C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x0601A4D7 RID: 107735 RVA: 0x003D5A75 File Offset: 0x003D3C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDoneRequest.Descriptor;
			}
		}

		// Token: 0x0601A4D8 RID: 107736 RVA: 0x003D5A7C File Offset: 0x003D3C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest()
		{
		}

		// Token: 0x0601A4D9 RID: 107737 RVA: 0x003D5A8F File Offset: 0x003D3C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest(SurvivorsOpDoneRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.clientSelectIds_ = other.clientSelectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4DA RID: 107738 RVA: 0x003D5AC5 File Offset: 0x003D3CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest Clone()
		{
			return new SurvivorsOpDoneRequest(this);
		}

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x0601A4DB RID: 107739 RVA: 0x003D5ACD File Offset: 0x003D3CCD
		// (set) Token: 0x0601A4DC RID: 107740 RVA: 0x003D5AD5 File Offset: 0x003D3CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x0601A4DD RID: 107741 RVA: 0x003D5ADE File Offset: 0x003D3CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClientSelectIds
		{
			get
			{
				return this.clientSelectIds_;
			}
		}

		// Token: 0x0601A4DE RID: 107742 RVA: 0x003D5AE6 File Offset: 0x003D3CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDoneRequest);
		}

		// Token: 0x0601A4DF RID: 107743 RVA: 0x003D5AF4 File Offset: 0x003D3CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDoneRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.clientSelectIds_.Equals(other.clientSelectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4E0 RID: 107744 RVA: 0x003D5B44 File Offset: 0x003D3D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.clientSelectIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x003D5B91 File Offset: 0x003D3D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x003D5B9E File Offset: 0x003D3D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4E3 RID: 107747 RVA: 0x003D5BA8 File Offset: 0x003D3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			this.clientSelectIds_.WriteTo(ref output, SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4E4 RID: 107748 RVA: 0x003D5BF8 File Offset: 0x003D3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.clientSelectIds_.CalculateSize(SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4E5 RID: 107749 RVA: 0x003D5C4C File Offset: 0x003D3E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDoneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.clientSelectIds_.Add(other.clientSelectIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4E6 RID: 107750 RVA: 0x003D5C99 File Offset: 0x003D3E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4E7 RID: 107751 RVA: 0x003D5CA4 File Offset: 0x003D3EA4
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
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.clientSelectIds_.AddEntriesFrom(ref input, SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A9E RID: 39582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A9F RID: 39583
		public const int IncIdFieldNumber = 6;

		// Token: 0x04009AA0 RID: 39584
		private int incId_;

		// Token: 0x04009AA1 RID: 39585
		public const int ClientSelectIdsFieldNumber = 10;

		// Token: 0x04009AA2 RID: 39586
		private static readonly FieldCodec<int> _repeated_clientSelectIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009AA3 RID: 39587
		private readonly RepeatedField<int> clientSelectIds_ = new RepeatedField<int>();
	}
}
