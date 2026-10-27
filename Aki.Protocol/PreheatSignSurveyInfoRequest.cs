using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD1 RID: 3537
	[NetMessage(EMessageId.PreheatSignSurveyInfoRequest)]
	public sealed class PreheatSignSurveyInfoRequest : IMessage<PreheatSignSurveyInfoRequest>, IMessage, IEquatable<PreheatSignSurveyInfoRequest>, IDeepCloneable<PreheatSignSurveyInfoRequest>, IBufferMessage
	{
		// Token: 0x060130A5 RID: 77989 RVA: 0x002C66D2 File Offset: 0x002C48D2
		[NullableContext(1)]
		public static PreheatSignSurveyInfoRequest Create()
		{
			return new PreheatSignSurveyInfoRequest();
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x060130A6 RID: 77990 RVA: 0x002C66D9 File Offset: 0x002C48D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x060130A7 RID: 77991 RVA: 0x002C66DC File Offset: 0x002C48DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfoRequest.Descriptor;
			}
		}

		// Token: 0x060130A8 RID: 77992 RVA: 0x002C66E3 File Offset: 0x002C48E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest()
		{
		}

		// Token: 0x060130A9 RID: 77993 RVA: 0x002C66EB File Offset: 0x002C48EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest(PreheatSignSurveyInfoRequest other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130AA RID: 77994 RVA: 0x002C6710 File Offset: 0x002C4910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoRequest Clone()
		{
			return new PreheatSignSurveyInfoRequest(this);
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x060130AB RID: 77995 RVA: 0x002C6718 File Offset: 0x002C4918
		// (set) Token: 0x060130AC RID: 77996 RVA: 0x002C6720 File Offset: 0x002C4920
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

		// Token: 0x060130AD RID: 77997 RVA: 0x002C6729 File Offset: 0x002C4929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfoRequest);
		}

		// Token: 0x060130AE RID: 77998 RVA: 0x002C6737 File Offset: 0x002C4937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfoRequest other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130AF RID: 77999 RVA: 0x002C6768 File Offset: 0x002C4968
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

		// Token: 0x060130B0 RID: 78000 RVA: 0x002C67A7 File Offset: 0x002C49A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130B1 RID: 78001 RVA: 0x002C67B4 File Offset: 0x002C49B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130B2 RID: 78002 RVA: 0x002C67BD File Offset: 0x002C49BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130B3 RID: 78003 RVA: 0x002C67F0 File Offset: 0x002C49F0
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

		// Token: 0x060130B4 RID: 78004 RVA: 0x002C682E File Offset: 0x002C4A2E
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

		// Token: 0x060130B5 RID: 78005 RVA: 0x002C685F File Offset: 0x002C4A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130B6 RID: 78006 RVA: 0x002C6868 File Offset: 0x002C4A68
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PreheatNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007589 RID: 30089
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400758A RID: 30090
		public const int PreheatNodeIdFieldNumber = 7;

		// Token: 0x0400758B RID: 30091
		private int preheatNodeId_;
	}
}
