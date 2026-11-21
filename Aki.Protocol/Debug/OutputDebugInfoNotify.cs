using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001718 RID: 5912
	[NetMessage(EMessageId.OutputDebugInfoNotify)]
	public sealed class OutputDebugInfoNotify : IMessage<OutputDebugInfoNotify>, IMessage, IEquatable<OutputDebugInfoNotify>, IDeepCloneable<OutputDebugInfoNotify>, IBufferMessage
	{
		// Token: 0x0601DAFA RID: 121594 RVA: 0x0045B004 File Offset: 0x00459204
		[NullableContext(1)]
		public static OutputDebugInfoNotify Create()
		{
			return new OutputDebugInfoNotify();
		}

		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x0601DAFB RID: 121595 RVA: 0x0045B00B File Offset: 0x0045920B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x0601DAFC RID: 121596 RVA: 0x0045B00E File Offset: 0x0045920E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601DAFD RID: 121597 RVA: 0x0045B015 File Offset: 0x00459215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify()
		{
		}

		// Token: 0x0601DAFE RID: 121598 RVA: 0x0045B01D File Offset: 0x0045921D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify(OutputDebugInfoNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DAFF RID: 121599 RVA: 0x0045B036 File Offset: 0x00459236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify Clone()
		{
			return new OutputDebugInfoNotify(this);
		}

		// Token: 0x0601DB00 RID: 121600 RVA: 0x0045B03E File Offset: 0x0045923E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoNotify);
		}

		// Token: 0x0601DB01 RID: 121601 RVA: 0x0045B04C File Offset: 0x0045924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601DB02 RID: 121602 RVA: 0x0045B06C File Offset: 0x0045926C
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

		// Token: 0x0601DB03 RID: 121603 RVA: 0x0045B092 File Offset: 0x00459292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB04 RID: 121604 RVA: 0x0045B09F File Offset: 0x0045929F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB05 RID: 121605 RVA: 0x0045B0A8 File Offset: 0x004592A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB06 RID: 121606 RVA: 0x0045B0C0 File Offset: 0x004592C0
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

		// Token: 0x0601DB07 RID: 121607 RVA: 0x0045B0E6 File Offset: 0x004592E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OutputDebugInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DB08 RID: 121608 RVA: 0x0045B103 File Offset: 0x00459303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB09 RID: 121609 RVA: 0x0045B10C File Offset: 0x0045930C
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

		// Token: 0x0400C90C RID: 51468
		private UnknownFieldSet _unknownFields;
	}
}
