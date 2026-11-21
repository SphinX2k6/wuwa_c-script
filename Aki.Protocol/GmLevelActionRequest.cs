using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EC RID: 1772
	[NetMessage(EMessageId.GmLevelActionRequest)]
	public sealed class GmLevelActionRequest : IMessage<GmLevelActionRequest>, IMessage, IEquatable<GmLevelActionRequest>, IDeepCloneable<GmLevelActionRequest>, IBufferMessage
	{
		// Token: 0x0600A1D0 RID: 41424 RVA: 0x001879D1 File Offset: 0x00185BD1
		[NullableContext(1)]
		public static GmLevelActionRequest Create()
		{
			return new GmLevelActionRequest();
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600A1D1 RID: 41425 RVA: 0x001879D8 File Offset: 0x00185BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x001879DB File Offset: 0x00185BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionRequest.Descriptor;
			}
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x001879E2 File Offset: 0x00185BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest()
		{
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x001879F5 File Offset: 0x00185BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest(GmLevelActionRequest other) : this()
		{
			this.jsonStr_ = other.jsonStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x00187A1A File Offset: 0x00185C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest Clone()
		{
			return new GmLevelActionRequest(this);
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x00187A22 File Offset: 0x00185C22
		// (set) Token: 0x0600A1D7 RID: 41431 RVA: 0x00187A2A File Offset: 0x00185C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonStr
		{
			get
			{
				return this.jsonStr_;
			}
			set
			{
				this.jsonStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00187A3D File Offset: 0x00185C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionRequest);
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x00187A4B File Offset: 0x00185C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionRequest other)
		{
			return other != null && (other == this || (!(this.JsonStr != other.JsonStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x00187A80 File Offset: 0x00185C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JsonStr.Length != 0)
			{
				num ^= this.JsonStr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x00187AC1 File Offset: 0x00185CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00187ACE File Offset: 0x00185CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x00187AD7 File Offset: 0x00185CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JsonStr.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x00187B10 File Offset: 0x00185D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JsonStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x00187B53 File Offset: 0x00185D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JsonStr.Length != 0)
			{
				this.JsonStr = other.JsonStr;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x00187B89 File Offset: 0x00185D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x00187B94 File Offset: 0x00185D94
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.JsonStr = input.ReadString();
				}
			}
		}

		// Token: 0x04004B6F RID: 19311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B70 RID: 19312
		public const int JsonStrFieldNumber = 7;

		// Token: 0x04004B71 RID: 19313
		private string jsonStr_ = "";
	}
}
