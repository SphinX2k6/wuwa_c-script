using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007B RID: 123
	[NetMessage(EMessageId.ActivateBuffNotify)]
	public sealed class ActivateBuffNotify : IMessage<ActivateBuffNotify>, IMessage, IEquatable<ActivateBuffNotify>, IDeepCloneable<ActivateBuffNotify>, IBufferMessage
	{
		// Token: 0x06001888 RID: 6280 RVA: 0x0004048D File Offset: 0x0003E68D
		[NullableContext(1)]
		public static ActivateBuffNotify Create()
		{
			return new ActivateBuffNotify();
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00040494 File Offset: 0x0003E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00040497 File Offset: 0x0003E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0004049E File Offset: 0x0003E69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify()
		{
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x000404A6 File Offset: 0x0003E6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify(ActivateBuffNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x000404D7 File Offset: 0x0003E6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify Clone()
		{
			return new ActivateBuffNotify(this);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000404DF File Offset: 0x0003E6DF
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x000404E7 File Offset: 0x0003E6E7
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000404F0 File Offset: 0x0003E6F0
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x000404F8 File Offset: 0x0003E6F8
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

		// Token: 0x06001892 RID: 6290 RVA: 0x00040501 File Offset: 0x0003E701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffNotify);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0004050F File Offset: 0x0003E70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00040550 File Offset: 0x0003E750
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

		// Token: 0x06001895 RID: 6293 RVA: 0x000405A8 File Offset: 0x0003E7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000405B5 File Offset: 0x0003E7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000405C0 File Offset: 0x0003E7C0
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
				output.WriteRawTag(56);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0004061C File Offset: 0x0003E81C
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

		// Token: 0x06001899 RID: 6297 RVA: 0x00040668 File Offset: 0x0003E868
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

		// Token: 0x0600189A RID: 6298 RVA: 0x000406B8 File Offset: 0x0003E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000406C4 File Offset: 0x0003E8C4
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
					if (num != 56U)
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

		// Token: 0x040021D4 RID: 8660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021D5 RID: 8661
		public const int HandleFieldNumber = 7;

		// Token: 0x040021D6 RID: 8662
		private int handle_;

		// Token: 0x040021D7 RID: 8663
		public const int OnFieldNumber = 2;

		// Token: 0x040021D8 RID: 8664
		private bool on_;
	}
}
