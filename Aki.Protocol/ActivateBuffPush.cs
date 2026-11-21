using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007C RID: 124
	[NetMessage(EMessageId.ActivateBuffPush)]
	public sealed class ActivateBuffPush : IMessage<ActivateBuffPush>, IMessage, IEquatable<ActivateBuffPush>, IDeepCloneable<ActivateBuffPush>, IBufferMessage
	{
		// Token: 0x0600189C RID: 6300 RVA: 0x0004071C File Offset: 0x0003E91C
		[NullableContext(1)]
		public static ActivateBuffPush Create()
		{
			return new ActivateBuffPush();
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00040723 File Offset: 0x0003E923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x00040726 File Offset: 0x0003E926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffPush.Descriptor;
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0004072D File Offset: 0x0003E92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush()
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00040735 File Offset: 0x0003E935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush(ActivateBuffPush other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00040766 File Offset: 0x0003E966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush Clone()
		{
			return new ActivateBuffPush(this);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0004076E File Offset: 0x0003E96E
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x00040776 File Offset: 0x0003E976
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0004077F File Offset: 0x0003E97F
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x00040787 File Offset: 0x0003E987
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

		// Token: 0x060018A6 RID: 6310 RVA: 0x00040790 File Offset: 0x0003E990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffPush);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0004079E File Offset: 0x0003E99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000407DC File Offset: 0x0003E9DC
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

		// Token: 0x060018A9 RID: 6313 RVA: 0x00040834 File Offset: 0x0003EA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00040841 File Offset: 0x0003EA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0004084C File Offset: 0x0003EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Handle);
			}
			if (this.On)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.On);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000408A8 File Offset: 0x0003EAA8
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

		// Token: 0x060018AD RID: 6317 RVA: 0x000408F4 File Offset: 0x0003EAF4
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

		// Token: 0x060018AE RID: 6318 RVA: 0x00040944 File Offset: 0x0003EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00040950 File Offset: 0x0003EB50
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
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.On = input.ReadBool();
					}
				}
				else
				{
					this.Handle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040021D9 RID: 8665
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021DA RID: 8666
		public const int HandleFieldNumber = 13;

		// Token: 0x040021DB RID: 8667
		private int handle_;

		// Token: 0x040021DC RID: 8668
		public const int OnFieldNumber = 15;

		// Token: 0x040021DD RID: 8669
		private bool on_;
	}
}
