using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EC RID: 2540
	[NetMessage(EMessageId.ModifyNameRequest)]
	public sealed class ModifyNameRequest : IMessage<ModifyNameRequest>, IMessage, IEquatable<ModifyNameRequest>, IDeepCloneable<ModifyNameRequest>, IBufferMessage
	{
		// Token: 0x0600DE7D RID: 56957 RVA: 0x0020A094 File Offset: 0x00208294
		[NullableContext(1)]
		public static ModifyNameRequest Create()
		{
			return new ModifyNameRequest();
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600DE7E RID: 56958 RVA: 0x0020A09B File Offset: 0x0020829B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x0020A09E File Offset: 0x0020829E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyNameRequest.Descriptor;
			}
		}

		// Token: 0x0600DE80 RID: 56960 RVA: 0x0020A0A5 File Offset: 0x002082A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest()
		{
		}

		// Token: 0x0600DE81 RID: 56961 RVA: 0x0020A0B8 File Offset: 0x002082B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest(ModifyNameRequest other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE82 RID: 56962 RVA: 0x0020A0DD File Offset: 0x002082DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest Clone()
		{
			return new ModifyNameRequest(this);
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x0020A0E5 File Offset: 0x002082E5
		// (set) Token: 0x0600DE84 RID: 56964 RVA: 0x0020A0ED File Offset: 0x002082ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DE85 RID: 56965 RVA: 0x0020A100 File Offset: 0x00208300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyNameRequest);
		}

		// Token: 0x0600DE86 RID: 56966 RVA: 0x0020A10E File Offset: 0x0020830E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyNameRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x0020A144 File Offset: 0x00208344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x0020A185 File Offset: 0x00208385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE89 RID: 56969 RVA: 0x0020A192 File Offset: 0x00208392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE8A RID: 56970 RVA: 0x0020A19B File Offset: 0x0020839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE8B RID: 56971 RVA: 0x0020A1D4 File Offset: 0x002083D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE8C RID: 56972 RVA: 0x0020A217 File Offset: 0x00208417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE8D RID: 56973 RVA: 0x0020A24D File Offset: 0x0020844D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE8E RID: 56974 RVA: 0x0020A258 File Offset: 0x00208458
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04005BD8 RID: 23512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD9 RID: 23513
		public const int NameFieldNumber = 9;

		// Token: 0x04005BDA RID: 23514
		private string name_ = "";
	}
}
