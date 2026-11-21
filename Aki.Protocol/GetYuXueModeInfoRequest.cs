using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BF RID: 1727
	[NetMessage(EMessageId.GetYuXueModeInfoRequest)]
	public sealed class GetYuXueModeInfoRequest : IMessage<GetYuXueModeInfoRequest>, IMessage, IEquatable<GetYuXueModeInfoRequest>, IDeepCloneable<GetYuXueModeInfoRequest>, IBufferMessage
	{
		// Token: 0x06009E44 RID: 40516 RVA: 0x001801A4 File Offset: 0x0017E3A4
		[NullableContext(1)]
		public static GetYuXueModeInfoRequest Create()
		{
			return new GetYuXueModeInfoRequest();
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06009E45 RID: 40517 RVA: 0x001801AB File Offset: 0x0017E3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06009E46 RID: 40518 RVA: 0x001801AE File Offset: 0x0017E3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetYuXueModeInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x001801B5 File Offset: 0x0017E3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest()
		{
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x001801BD File Offset: 0x0017E3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest(GetYuXueModeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x001801D6 File Offset: 0x0017E3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest Clone()
		{
			return new GetYuXueModeInfoRequest(this);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x001801DE File Offset: 0x0017E3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetYuXueModeInfoRequest);
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x001801EC File Offset: 0x0017E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetYuXueModeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x0018020C File Offset: 0x0017E40C
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

		// Token: 0x06009E4D RID: 40525 RVA: 0x00180232 File Offset: 0x0017E432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x0018023F File Offset: 0x0017E43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x00180248 File Offset: 0x0017E448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x00180260 File Offset: 0x0017E460
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

		// Token: 0x06009E51 RID: 40529 RVA: 0x00180286 File Offset: 0x0017E486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetYuXueModeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x001802A3 File Offset: 0x0017E4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x001802AC File Offset: 0x0017E4AC
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

		// Token: 0x04004A6E RID: 19054
		private UnknownFieldSet _unknownFields;
	}
}
