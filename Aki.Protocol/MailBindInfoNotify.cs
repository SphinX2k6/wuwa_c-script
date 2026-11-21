using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095E RID: 2398
	[NetMessage(EMessageId.MailBindInfoNotify)]
	public sealed class MailBindInfoNotify : IMessage<MailBindInfoNotify>, IMessage, IEquatable<MailBindInfoNotify>, IDeepCloneable<MailBindInfoNotify>, IBufferMessage
	{
		// Token: 0x0600D38A RID: 54154 RVA: 0x001F2E12 File Offset: 0x001F1012
		[NullableContext(1)]
		public static MailBindInfoNotify Create()
		{
			return new MailBindInfoNotify();
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0600D38B RID: 54155 RVA: 0x001F2E19 File Offset: 0x001F1019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x001F2E1C File Offset: 0x001F101C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600D38D RID: 54157 RVA: 0x001F2E23 File Offset: 0x001F1023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify()
		{
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x001F2E2B File Offset: 0x001F102B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify(MailBindInfoNotify other) : this()
		{
			this.mailBindInfo_ = ((other.mailBindInfo_ != null) ? other.mailBindInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x001F2E60 File Offset: 0x001F1060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify Clone()
		{
			return new MailBindInfoNotify(this);
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0600D390 RID: 54160 RVA: 0x001F2E68 File Offset: 0x001F1068
		// (set) Token: 0x0600D391 RID: 54161 RVA: 0x001F2E70 File Offset: 0x001F1070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo MailBindInfo
		{
			get
			{
				return this.mailBindInfo_;
			}
			set
			{
				this.mailBindInfo_ = value;
			}
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x001F2E79 File Offset: 0x001F1079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoNotify);
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x001F2E87 File Offset: 0x001F1087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MailBindInfo, other.MailBindInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D394 RID: 54164 RVA: 0x001F2EBC File Offset: 0x001F10BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mailBindInfo_ != null)
			{
				num ^= this.MailBindInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D395 RID: 54165 RVA: 0x001F2EF8 File Offset: 0x001F10F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D396 RID: 54166 RVA: 0x001F2F05 File Offset: 0x001F1105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x001F2F0E File Offset: 0x001F110E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mailBindInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D398 RID: 54168 RVA: 0x001F2F40 File Offset: 0x001F1140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mailBindInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D399 RID: 54169 RVA: 0x001F2F80 File Offset: 0x001F1180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mailBindInfo_ != null)
			{
				if (this.mailBindInfo_ == null)
				{
					this.MailBindInfo = new MailBindInfo();
				}
				this.MailBindInfo.MergeFrom(other.MailBindInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x001F2FD4 File Offset: 0x001F11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D39B RID: 54171 RVA: 0x001F2FE0 File Offset: 0x001F11E0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.mailBindInfo_ == null)
					{
						this.MailBindInfo = new MailBindInfo();
					}
					input.ReadMessage(this.MailBindInfo);
				}
			}
		}

		// Token: 0x0400593C RID: 22844
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400593D RID: 22845
		public const int MailBindInfoFieldNumber = 15;

		// Token: 0x0400593E RID: 22846
		private MailBindInfo mailBindInfo_;
	}
}
