using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000091 RID: 145
	[NetMessage(EMessageId.ActivityRequest)]
	public sealed class ActivityRequest : IMessage<ActivityRequest>, IMessage, IEquatable<ActivityRequest>, IDeepCloneable<ActivityRequest>, IBufferMessage
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x0004CA6E File Offset: 0x0004AC6E
		[NullableContext(1)]
		public static ActivityRequest Create()
		{
			return new ActivityRequest();
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0004CA75 File Offset: 0x0004AC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0004CA78 File Offset: 0x0004AC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRequest.Descriptor;
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0004CA7F File Offset: 0x0004AC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest()
		{
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0004CA87 File Offset: 0x0004AC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest(ActivityRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRequest Clone()
		{
			return new ActivityRequest(this);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0004CAA8 File Offset: 0x0004ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRequest);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0004CAB6 File Offset: 0x0004ACB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0004CAD4 File Offset: 0x0004ACD4
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

		// Token: 0x06001B52 RID: 6994 RVA: 0x0004CAFA File Offset: 0x0004ACFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0004CB07 File Offset: 0x0004AD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0004CB10 File Offset: 0x0004AD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0004CB28 File Offset: 0x0004AD28
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

		// Token: 0x06001B56 RID: 6998 RVA: 0x0004CB4E File Offset: 0x0004AD4E
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

		// Token: 0x06001B57 RID: 6999 RVA: 0x0004CB6B File Offset: 0x0004AD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0004CB74 File Offset: 0x0004AD74
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

		// Token: 0x040022DD RID: 8925
		private UnknownFieldSet _unknownFields;
	}
}
