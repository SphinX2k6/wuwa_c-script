using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007B RID: 123
	[NetMessage(EMessageId.ActivateBuffPush)]
	public sealed class ActivateBuffPush : IMessage<ActivateBuffPush>, IMessage, IEquatable<ActivateBuffPush>, IDeepCloneable<ActivateBuffPush>, IBufferMessage
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x0003FD6F File Offset: 0x0003DF6F
		[NullableContext(1)]
		public static ActivateBuffPush Create()
		{
			return new ActivateBuffPush();
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0003FD76 File Offset: 0x0003DF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0003FD79 File Offset: 0x0003DF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffPush.Descriptor;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0003FD80 File Offset: 0x0003DF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush()
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0003FD88 File Offset: 0x0003DF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush(ActivateBuffPush other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0003FDB9 File Offset: 0x0003DFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush Clone()
		{
			return new ActivateBuffPush(this);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0003FDC1 File Offset: 0x0003DFC1
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x0003FDC9 File Offset: 0x0003DFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0003FDD2 File Offset: 0x0003DFD2
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0003FDDA File Offset: 0x0003DFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool On
		{
			get
			{
				return this.on_;
			}
			set
			{
				this.on_ = value;
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0003FDE3 File Offset: 0x0003DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffPush);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0003FDF1 File Offset: 0x0003DFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0003FE30 File Offset: 0x0003E030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.On)
			{
				num ^= this.On.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0003FE88 File Offset: 0x0003E088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0003FE95 File Offset: 0x0003E095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.On)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.On);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0003FEFC File Offset: 0x0003E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.On)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0003FF48 File Offset: 0x0003E148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateBuffPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.On)
			{
				this.On = other.On;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0003FF98 File Offset: 0x0003E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0003FFA4 File Offset: 0x0003E1A4
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Handle = input.ReadInt32();
					}
				}
				else
				{
					this.On = input.ReadBool();
				}
			}
		}

		// Token: 0x0400217A RID: 8570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400217B RID: 8571
		public const int HandleFieldNumber = 5;

		// Token: 0x0400217C RID: 8572
		private int handle_;

		// Token: 0x0400217D RID: 8573
		public const int OnFieldNumber = 2;

		// Token: 0x0400217E RID: 8574
		private bool on_;
	}
}
