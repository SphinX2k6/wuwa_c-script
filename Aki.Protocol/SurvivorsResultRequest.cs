using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DD RID: 4829
	[NetMessage(EMessageId.SurvivorsResultRequest)]
	public sealed class SurvivorsResultRequest : IMessage<SurvivorsResultRequest>, IMessage, IEquatable<SurvivorsResultRequest>, IDeepCloneable<SurvivorsResultRequest>, IBufferMessage
	{
		// Token: 0x06019B07 RID: 105223 RVA: 0x003BC1B2 File Offset: 0x003BA3B2
		[NullableContext(1)]
		public static SurvivorsResultRequest Create()
		{
			return new SurvivorsResultRequest();
		}

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x06019B08 RID: 105224 RVA: 0x003BC1B9 File Offset: 0x003BA3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x06019B09 RID: 105225 RVA: 0x003BC1BC File Offset: 0x003BA3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsResultRequest.Descriptor;
			}
		}

		// Token: 0x06019B0A RID: 105226 RVA: 0x003BC1C3 File Offset: 0x003BA3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest()
		{
		}

		// Token: 0x06019B0B RID: 105227 RVA: 0x003BC1CB File Offset: 0x003BA3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest(SurvivorsResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B0C RID: 105228 RVA: 0x003BC1E4 File Offset: 0x003BA3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest Clone()
		{
			return new SurvivorsResultRequest(this);
		}

		// Token: 0x06019B0D RID: 105229 RVA: 0x003BC1EC File Offset: 0x003BA3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsResultRequest);
		}

		// Token: 0x06019B0E RID: 105230 RVA: 0x003BC1FA File Offset: 0x003BA3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019B0F RID: 105231 RVA: 0x003BC218 File Offset: 0x003BA418
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

		// Token: 0x06019B10 RID: 105232 RVA: 0x003BC23E File Offset: 0x003BA43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B11 RID: 105233 RVA: 0x003BC24B File Offset: 0x003BA44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B12 RID: 105234 RVA: 0x003BC254 File Offset: 0x003BA454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B13 RID: 105235 RVA: 0x003BC26C File Offset: 0x003BA46C
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

		// Token: 0x06019B14 RID: 105236 RVA: 0x003BC292 File Offset: 0x003BA492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B15 RID: 105237 RVA: 0x003BC2AF File Offset: 0x003BA4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B16 RID: 105238 RVA: 0x003BC2B8 File Offset: 0x003BA4B8
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

		// Token: 0x04009693 RID: 38547
		private UnknownFieldSet _unknownFields;
	}
}
