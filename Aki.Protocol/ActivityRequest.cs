using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000090 RID: 144
	[NetMessage(EMessageId.ActivityRequest)]
	public sealed class ActivityRequest : IMessage<ActivityRequest>, IMessage, IEquatable<ActivityRequest>, IDeepCloneable<ActivityRequest>, IBufferMessage
	{
		// Token: 0x06001B02 RID: 6914 RVA: 0x0004BE5E File Offset: 0x0004A05E
		[NullableContext(1)]
		public static ActivityRequest Create()
		{
			return new ActivityRequest();
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0004BE65 File Offset: 0x0004A065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0004BE68 File Offset: 0x0004A068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRequest.Descriptor;
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0004BE6F File Offset: 0x0004A06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest()
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0004BE77 File Offset: 0x0004A077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest(ActivityRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0004BE90 File Offset: 0x0004A090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest Clone()
		{
			return new ActivityRequest(this);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0004BE98 File Offset: 0x0004A098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRequest);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0004BEA6 File Offset: 0x0004A0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0004BEC4 File Offset: 0x0004A0C4
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

		// Token: 0x06001B0B RID: 6923 RVA: 0x0004BEEA File Offset: 0x0004A0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0004BEF7 File Offset: 0x0004A0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0004BF00 File Offset: 0x0004A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0004BF18 File Offset: 0x0004A118
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

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004BF3E File Offset: 0x0004A13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004BF5B File Offset: 0x0004A15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0004BF64 File Offset: 0x0004A164
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

		// Token: 0x0400227C RID: 8828
		private UnknownFieldSet _unknownFields;
	}
}
