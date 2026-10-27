using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007A RID: 122
	[NetMessage(EMessageId.ActivateBuffNotify)]
	public sealed class ActivateBuffNotify : IMessage<ActivateBuffNotify>, IMessage, IEquatable<ActivateBuffNotify>, IDeepCloneable<ActivateBuffNotify>, IBufferMessage
	{
		// Token: 0x06001845 RID: 6213 RVA: 0x0003FAE8 File Offset: 0x0003DCE8
		[NullableContext(1)]
		public static ActivateBuffNotify Create()
		{
			return new ActivateBuffNotify();
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0003FAEF File Offset: 0x0003DCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0003FAF2 File Offset: 0x0003DCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffNotify.Descriptor;
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0003FAF9 File Offset: 0x0003DCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify()
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0003FB01 File Offset: 0x0003DD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify(ActivateBuffNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0003FB32 File Offset: 0x0003DD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify Clone()
		{
			return new ActivateBuffNotify(this);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0003FB3A File Offset: 0x0003DD3A
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0003FB42 File Offset: 0x0003DD42
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0003FB4B File Offset: 0x0003DD4B
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0003FB53 File Offset: 0x0003DD53
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

		// Token: 0x0600184F RID: 6223 RVA: 0x0003FB5C File Offset: 0x0003DD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffNotify);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0003FB6A File Offset: 0x0003DD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
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

		// Token: 0x06001852 RID: 6226 RVA: 0x0003FC00 File Offset: 0x0003DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0003FC0D File Offset: 0x0003DE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0003FC18 File Offset: 0x0003DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.On)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.On);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0003FC70 File Offset: 0x0003DE70
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

		// Token: 0x06001856 RID: 6230 RVA: 0x0003FCBC File Offset: 0x0003DEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateBuffNotify other)
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

		// Token: 0x06001857 RID: 6231 RVA: 0x0003FD0C File Offset: 0x0003DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0003FD18 File Offset: 0x0003DF18
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
				if (num != 8U)
				{
					if (num != 64U)
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

		// Token: 0x04002175 RID: 8565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002176 RID: 8566
		public const int HandleFieldNumber = 8;

		// Token: 0x04002177 RID: 8567
		private int handle_;

		// Token: 0x04002178 RID: 8568
		public const int OnFieldNumber = 1;

		// Token: 0x04002179 RID: 8569
		private bool on_;
	}
}
