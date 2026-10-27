using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007C RID: 124
	[NetMessage(EMessageId.ActivateBuffRequest)]
	public sealed class ActivateBuffRequest : IMessage<ActivateBuffRequest>, IMessage, IEquatable<ActivateBuffRequest>, IDeepCloneable<ActivateBuffRequest>, IBufferMessage
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		[NullableContext(1)]
		public static ActivateBuffRequest Create()
		{
			return new ActivateBuffRequest();
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00040003 File Offset: 0x0003E203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00040006 File Offset: 0x0003E206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffRequest.Descriptor;
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0004000D File Offset: 0x0003E20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest()
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00040015 File Offset: 0x0003E215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest(ActivateBuffRequest other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00040046 File Offset: 0x0003E246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest Clone()
		{
			return new ActivateBuffRequest(this);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0004004E File Offset: 0x0003E24E
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x00040056 File Offset: 0x0003E256
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0004005F File Offset: 0x0003E25F
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00040067 File Offset: 0x0003E267
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

		// Token: 0x06001877 RID: 6263 RVA: 0x00040070 File Offset: 0x0003E270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffRequest);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0004007E File Offset: 0x0003E27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000400BC File Offset: 0x0003E2BC
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

		// Token: 0x0600187A RID: 6266 RVA: 0x00040114 File Offset: 0x0003E314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00040121 File Offset: 0x0003E321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0004012C File Offset: 0x0003E32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(8);
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

		// Token: 0x0600187D RID: 6269 RVA: 0x00040184 File Offset: 0x0003E384
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

		// Token: 0x0600187E RID: 6270 RVA: 0x000401D0 File Offset: 0x0003E3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateBuffRequest other)
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

		// Token: 0x0600187F RID: 6271 RVA: 0x00040220 File Offset: 0x0003E420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0004022C File Offset: 0x0003E42C
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

		// Token: 0x0400217F RID: 8575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002180 RID: 8576
		public const int HandleFieldNumber = 1;

		// Token: 0x04002181 RID: 8577
		private int handle_;

		// Token: 0x04002182 RID: 8578
		public const int OnFieldNumber = 15;

		// Token: 0x04002183 RID: 8579
		private bool on_;
	}
}
