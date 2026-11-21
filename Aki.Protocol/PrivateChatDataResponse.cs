using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCD RID: 3533
	[NetMessage(EMessageId.PrivateChatDataResponse)]
	public sealed class PrivateChatDataResponse : IMessage<PrivateChatDataResponse>, IMessage, IEquatable<PrivateChatDataResponse>, IDeepCloneable<PrivateChatDataResponse>, IBufferMessage
	{
		// Token: 0x060130A8 RID: 77992 RVA: 0x002C6CEA File Offset: 0x002C4EEA
		[NullableContext(1)]
		public static PrivateChatDataResponse Create()
		{
			return new PrivateChatDataResponse();
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x060130A9 RID: 77993 RVA: 0x002C6CF1 File Offset: 0x002C4EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x060130AA RID: 77994 RVA: 0x002C6CF4 File Offset: 0x002C4EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatDataResponse.Descriptor;
			}
		}

		// Token: 0x060130AB RID: 77995 RVA: 0x002C6CFB File Offset: 0x002C4EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse()
		{
		}

		// Token: 0x060130AC RID: 77996 RVA: 0x002C6D03 File Offset: 0x002C4F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse(PrivateChatDataResponse other) : this()
		{
			this.loadSucc_ = other.loadSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130AD RID: 77997 RVA: 0x002C6D28 File Offset: 0x002C4F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse Clone()
		{
			return new PrivateChatDataResponse(this);
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x060130AE RID: 77998 RVA: 0x002C6D30 File Offset: 0x002C4F30
		// (set) Token: 0x060130AF RID: 77999 RVA: 0x002C6D38 File Offset: 0x002C4F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LoadSucc
		{
			get
			{
				return this.loadSucc_;
			}
			set
			{
				this.loadSucc_ = value;
			}
		}

		// Token: 0x060130B0 RID: 78000 RVA: 0x002C6D41 File Offset: 0x002C4F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatDataResponse);
		}

		// Token: 0x060130B1 RID: 78001 RVA: 0x002C6D4F File Offset: 0x002C4F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatDataResponse other)
		{
			return other != null && (other == this || (this.LoadSucc == other.LoadSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130B2 RID: 78002 RVA: 0x002C6D80 File Offset: 0x002C4F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadSucc)
			{
				num ^= this.LoadSucc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060130B3 RID: 78003 RVA: 0x002C6DBF File Offset: 0x002C4FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130B4 RID: 78004 RVA: 0x002C6DCC File Offset: 0x002C4FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130B5 RID: 78005 RVA: 0x002C6DD5 File Offset: 0x002C4FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadSucc)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.LoadSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130B6 RID: 78006 RVA: 0x002C6E08 File Offset: 0x002C5008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadSucc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060130B7 RID: 78007 RVA: 0x002C6E3A File Offset: 0x002C503A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadSucc)
			{
				this.LoadSucc = other.LoadSucc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060130B8 RID: 78008 RVA: 0x002C6E6B File Offset: 0x002C506B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130B9 RID: 78009 RVA: 0x002C6E74 File Offset: 0x002C5074
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x040075E7 RID: 30183
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075E8 RID: 30184
		public const int LoadSuccFieldNumber = 13;

		// Token: 0x040075E9 RID: 30185
		private bool loadSucc_;
	}
}
