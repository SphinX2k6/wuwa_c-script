using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F02 RID: 3842
	[NetMessage(EMessageId.RemoveOccupationInfoNotify)]
	public sealed class RemoveOccupationInfoNotify : IMessage<RemoveOccupationInfoNotify>, IMessage, IEquatable<RemoveOccupationInfoNotify>, IDeepCloneable<RemoveOccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x06014948 RID: 84296 RVA: 0x002FD3A1 File Offset: 0x002FB5A1
		[NullableContext(1)]
		public static RemoveOccupationInfoNotify Create()
		{
			return new RemoveOccupationInfoNotify();
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x06014949 RID: 84297 RVA: 0x002FD3A8 File Offset: 0x002FB5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x0601494A RID: 84298 RVA: 0x002FD3AB File Offset: 0x002FB5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveOccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601494B RID: 84299 RVA: 0x002FD3B2 File Offset: 0x002FB5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify()
		{
		}

		// Token: 0x0601494C RID: 84300 RVA: 0x002FD3C5 File Offset: 0x002FB5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify(RemoveOccupationInfoNotify other) : this()
		{
			this.resource_ = other.resource_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601494D RID: 84301 RVA: 0x002FD3EF File Offset: 0x002FB5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify Clone()
		{
			return new RemoveOccupationInfoNotify(this);
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x0601494E RID: 84302 RVA: 0x002FD3F7 File Offset: 0x002FB5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Resource
		{
			get
			{
				return this.resource_;
			}
		}

		// Token: 0x0601494F RID: 84303 RVA: 0x002FD3FF File Offset: 0x002FB5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveOccupationInfoNotify);
		}

		// Token: 0x06014950 RID: 84304 RVA: 0x002FD40D File Offset: 0x002FB60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveOccupationInfoNotify other)
		{
			return other != null && (other == this || (this.resource_.Equals(other.resource_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014951 RID: 84305 RVA: 0x002FD440 File Offset: 0x002FB640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.resource_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014952 RID: 84306 RVA: 0x002FD474 File Offset: 0x002FB674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014953 RID: 84307 RVA: 0x002FD481 File Offset: 0x002FB681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014954 RID: 84308 RVA: 0x002FD48A File Offset: 0x002FB68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.resource_.WriteTo(ref output, RemoveOccupationInfoNotify._repeated_resource_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014955 RID: 84309 RVA: 0x002FD4B4 File Offset: 0x002FB6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.resource_.CalculateSize(RemoveOccupationInfoNotify._repeated_resource_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014956 RID: 84310 RVA: 0x002FD4ED File Offset: 0x002FB6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveOccupationInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.resource_.Add(other.resource_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014957 RID: 84311 RVA: 0x002FD51B File Offset: 0x002FB71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014958 RID: 84312 RVA: 0x002FD524 File Offset: 0x002FB724
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.resource_.AddEntriesFrom(ref input, RemoveOccupationInfoNotify._repeated_resource_codec);
				}
			}
		}

		// Token: 0x04007CA7 RID: 31911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CA8 RID: 31912
		public const int ResourceFieldNumber = 13;

		// Token: 0x04007CA9 RID: 31913
		private static readonly FieldCodec<string> _repeated_resource_codec = FieldCodec.ForString(106U);

		// Token: 0x04007CAA RID: 31914
		private readonly RepeatedField<string> resource_ = new RepeatedField<string>();
	}
}
