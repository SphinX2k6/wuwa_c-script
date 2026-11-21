using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E7 RID: 5351
	[NetMessage(EMessageId.TutorialInfoRequest)]
	public sealed class TutorialInfoRequest : IMessage<TutorialInfoRequest>, IMessage, IEquatable<TutorialInfoRequest>, IDeepCloneable<TutorialInfoRequest>, IBufferMessage
	{
		// Token: 0x0601C609 RID: 116233 RVA: 0x0041E062 File Offset: 0x0041C262
		[NullableContext(1)]
		public static TutorialInfoRequest Create()
		{
			return new TutorialInfoRequest();
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x0601C60A RID: 116234 RVA: 0x0041E069 File Offset: 0x0041C269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x0601C60B RID: 116235 RVA: 0x0041E06C File Offset: 0x0041C26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601C60C RID: 116236 RVA: 0x0041E073 File Offset: 0x0041C273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest()
		{
		}

		// Token: 0x0601C60D RID: 116237 RVA: 0x0041E07B File Offset: 0x0041C27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest(TutorialInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C60E RID: 116238 RVA: 0x0041E094 File Offset: 0x0041C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest Clone()
		{
			return new TutorialInfoRequest(this);
		}

		// Token: 0x0601C60F RID: 116239 RVA: 0x0041E09C File Offset: 0x0041C29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfoRequest);
		}

		// Token: 0x0601C610 RID: 116240 RVA: 0x0041E0AA File Offset: 0x0041C2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C611 RID: 116241 RVA: 0x0041E0C8 File Offset: 0x0041C2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C612 RID: 116242 RVA: 0x0041E0EE File Offset: 0x0041C2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C613 RID: 116243 RVA: 0x0041E0FB File Offset: 0x0041C2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C614 RID: 116244 RVA: 0x0041E104 File Offset: 0x0041C304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C615 RID: 116245 RVA: 0x0041E11C File Offset: 0x0041C31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C616 RID: 116246 RVA: 0x0041E142 File Offset: 0x0041C342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C617 RID: 116247 RVA: 0x0041E15F File Offset: 0x0041C35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C618 RID: 116248 RVA: 0x0041E168 File Offset: 0x0041C368
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A3EE RID: 41966
		private UnknownFieldSet _unknownFields;
	}
}
