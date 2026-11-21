using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000058 RID: 88
	[NetMessage(EMessageId.AceAntiDataPush)]
	public sealed class AceAntiDataPush : IMessage<AceAntiDataPush>, IMessage, IEquatable<AceAntiDataPush>, IDeepCloneable<AceAntiDataPush>, IBufferMessage
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x000395B5 File Offset: 0x000377B5
		[NullableContext(1)]
		public static AceAntiDataPush Create()
		{
			return new AceAntiDataPush();
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000395BC File Offset: 0x000377BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000395BF File Offset: 0x000377BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiDataPush.Descriptor;
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000395C6 File Offset: 0x000377C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush()
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000395D9 File Offset: 0x000377D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush(AceAntiDataPush other) : this()
		{
			this.antiData_ = other.antiData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000395FE File Offset: 0x000377FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush Clone()
		{
			return new AceAntiDataPush(this);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00039606 File Offset: 0x00037806
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0003960E File Offset: 0x0003780E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString AntiData
		{
			get
			{
				return this.antiData_;
			}
			set
			{
				this.antiData_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00039621 File Offset: 0x00037821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiDataPush);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0003962F File Offset: 0x0003782F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiDataPush other)
		{
			return other != null && (other == this || (!(this.AntiData != other.AntiData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00039664 File Offset: 0x00037864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AntiData.Length != 0)
			{
				num ^= this.AntiData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000396A5 File Offset: 0x000378A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000396B2 File Offset: 0x000378B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000396BB File Offset: 0x000378BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AntiData.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000396F4 File Offset: 0x000378F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AntiData.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00039737 File Offset: 0x00037937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceAntiDataPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AntiData.Length != 0)
			{
				this.AntiData = other.AntiData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0003976D File Offset: 0x0003796D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00039778 File Offset: 0x00037978
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AntiData = input.ReadBytes();
				}
			}
		}

		// Token: 0x040020FB RID: 8443
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020FC RID: 8444
		public const int AntiDataFieldNumber = 7;

		// Token: 0x040020FD RID: 8445
		private ByteString antiData_ = ByteString.Empty;
	}
}
