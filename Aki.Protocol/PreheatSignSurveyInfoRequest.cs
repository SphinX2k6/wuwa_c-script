using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC1 RID: 3521
	[NetMessage(EMessageId.PreheatSignSurveyInfoRequest)]
	public sealed class PreheatSignSurveyInfoRequest : IMessage<PreheatSignSurveyInfoRequest>, IMessage, IEquatable<PreheatSignSurveyInfoRequest>, IDeepCloneable<PreheatSignSurveyInfoRequest>, IBufferMessage
	{
		// Token: 0x06012FC0 RID: 77760 RVA: 0x002C5012 File Offset: 0x002C3212
		[NullableContext(1)]
		public static PreheatSignSurveyInfoRequest Create()
		{
			return new PreheatSignSurveyInfoRequest();
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x06012FC1 RID: 77761 RVA: 0x002C5019 File Offset: 0x002C3219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x06012FC2 RID: 77762 RVA: 0x002C501C File Offset: 0x002C321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfoRequest.Descriptor;
			}
		}

		// Token: 0x06012FC3 RID: 77763 RVA: 0x002C5023 File Offset: 0x002C3223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest()
		{
		}

		// Token: 0x06012FC4 RID: 77764 RVA: 0x002C502B File Offset: 0x002C322B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest(PreheatSignSurveyInfoRequest other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FC5 RID: 77765 RVA: 0x002C5050 File Offset: 0x002C3250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest Clone()
		{
			return new PreheatSignSurveyInfoRequest(this);
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x06012FC6 RID: 77766 RVA: 0x002C5058 File Offset: 0x002C3258
		// (set) Token: 0x06012FC7 RID: 77767 RVA: 0x002C5060 File Offset: 0x002C3260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreheatNodeId
		{
			get
			{
				return this.preheatNodeId_;
			}
			set
			{
				this.preheatNodeId_ = value;
			}
		}

		// Token: 0x06012FC8 RID: 77768 RVA: 0x002C5069 File Offset: 0x002C3269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfoRequest);
		}

		// Token: 0x06012FC9 RID: 77769 RVA: 0x002C5077 File Offset: 0x002C3277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfoRequest other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FCA RID: 77770 RVA: 0x002C50A8 File Offset: 0x002C32A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreheatNodeId != 0)
			{
				num ^= this.PreheatNodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012FCB RID: 77771 RVA: 0x002C50E7 File Offset: 0x002C32E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FCC RID: 77772 RVA: 0x002C50F4 File Offset: 0x002C32F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FCD RID: 77773 RVA: 0x002C50FD File Offset: 0x002C32FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FCE RID: 77774 RVA: 0x002C5130 File Offset: 0x002C3330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreheatNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreheatNodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012FCF RID: 77775 RVA: 0x002C516E File Offset: 0x002C336E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignSurveyInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreheatNodeId != 0)
			{
				this.PreheatNodeId = other.PreheatNodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012FD0 RID: 77776 RVA: 0x002C519F File Offset: 0x002C339F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FD1 RID: 77777 RVA: 0x002C51A8 File Offset: 0x002C33A8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PreheatNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075B3 RID: 30131
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075B4 RID: 30132
		public const int PreheatNodeIdFieldNumber = 8;

		// Token: 0x040075B5 RID: 30133
		private int preheatNodeId_;
	}
}
