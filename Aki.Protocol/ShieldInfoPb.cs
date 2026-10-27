using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EB RID: 4587
	public sealed class ShieldInfoPb : IMessage<ShieldInfoPb>, IMessage, IEquatable<ShieldInfoPb>, IDeepCloneable<ShieldInfoPb>, IBufferMessage
	{
		// Token: 0x06018730 RID: 100144 RVA: 0x0038DF68 File Offset: 0x0038C168
		[NullableContext(1)]
		public static ShieldInfoPb Create()
		{
			return new ShieldInfoPb();
		}

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x06018731 RID: 100145 RVA: 0x0038DF6F File Offset: 0x0038C16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShieldInfoPb> Parser
		{
			get
			{
				return ShieldInfoPb._parser;
			}
		}

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x06018732 RID: 100146 RVA: 0x0038DF76 File Offset: 0x0038C176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x06018733 RID: 100147 RVA: 0x0038DF79 File Offset: 0x0038C179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldInfoPb.Descriptor;
			}
		}

		// Token: 0x06018734 RID: 100148 RVA: 0x0038DF80 File Offset: 0x0038C180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb()
		{
		}

		// Token: 0x06018735 RID: 100149 RVA: 0x0038DF88 File Offset: 0x0038C188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb(ShieldInfoPb other) : this()
		{
			this.handle_ = other.handle_;
			this.configId_ = other.configId_;
			this.shieldValue_ = other.shieldValue_;
			this.priority_ = other.priority_;
			this.buffHandle_ = other.buffHandle_;
			this.isValid_ = other.isValid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018736 RID: 100150 RVA: 0x0038DFF4 File Offset: 0x0038C1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb Clone()
		{
			return new ShieldInfoPb(this);
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x06018737 RID: 100151 RVA: 0x0038DFFC File Offset: 0x0038C1FC
		// (set) Token: 0x06018738 RID: 100152 RVA: 0x0038E004 File Offset: 0x0038C204
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

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x06018739 RID: 100153 RVA: 0x0038E00D File Offset: 0x0038C20D
		// (set) Token: 0x0601873A RID: 100154 RVA: 0x0038E015 File Offset: 0x0038C215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x0601873B RID: 100155 RVA: 0x0038E01E File Offset: 0x0038C21E
		// (set) Token: 0x0601873C RID: 100156 RVA: 0x0038E026 File Offset: 0x0038C226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldValue
		{
			get
			{
				return this.shieldValue_;
			}
			set
			{
				this.shieldValue_ = value;
			}
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x0601873D RID: 100157 RVA: 0x0038E02F File Offset: 0x0038C22F
		// (set) Token: 0x0601873E RID: 100158 RVA: 0x0038E037 File Offset: 0x0038C237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Priority
		{
			get
			{
				return this.priority_;
			}
			set
			{
				this.priority_ = value;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x0601873F RID: 100159 RVA: 0x0038E040 File Offset: 0x0038C240
		// (set) Token: 0x06018740 RID: 100160 RVA: 0x0038E048 File Offset: 0x0038C248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffHandle
		{
			get
			{
				return this.buffHandle_;
			}
			set
			{
				this.buffHandle_ = value;
			}
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x06018741 RID: 100161 RVA: 0x0038E051 File Offset: 0x0038C251
		// (set) Token: 0x06018742 RID: 100162 RVA: 0x0038E059 File Offset: 0x0038C259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsValid
		{
			get
			{
				return this.isValid_;
			}
			set
			{
				this.isValid_ = value;
			}
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x0038E062 File Offset: 0x0038C262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldInfoPb);
		}

		// Token: 0x06018744 RID: 100164 RVA: 0x0038E070 File Offset: 0x0038C270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldInfoPb other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.ConfigId == other.ConfigId && this.ShieldValue == other.ShieldValue && this.Priority == other.Priority && this.BuffHandle == other.BuffHandle && this.IsValid == other.IsValid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018745 RID: 100165 RVA: 0x0038E0FC File Offset: 0x0038C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ShieldValue != 0)
			{
				num ^= this.ShieldValue.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.BuffHandle != 0)
			{
				num ^= this.BuffHandle.GetHashCode();
			}
			if (this.IsValid)
			{
				num ^= this.IsValid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018746 RID: 100166 RVA: 0x0038E1B8 File Offset: 0x0038C3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018747 RID: 100167 RVA: 0x0038E1C5 File Offset: 0x0038C3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018748 RID: 100168 RVA: 0x0038E1D0 File Offset: 0x0038C3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Handle);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ShieldValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ShieldValue);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Priority);
			}
			if (this.BuffHandle != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BuffHandle);
			}
			if (this.IsValid)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsValid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018749 RID: 100169 RVA: 0x0038E298 File Offset: 0x0038C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ShieldValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldValue);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.BuffHandle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffHandle);
			}
			if (this.IsValid)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x0038E344 File Offset: 0x0038C544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ShieldValue != 0)
			{
				this.ShieldValue = other.ShieldValue;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.BuffHandle != 0)
			{
				this.BuffHandle = other.BuffHandle;
			}
			if (other.IsValid)
			{
				this.IsValid = other.IsValid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x0038E3E4 File Offset: 0x0038C5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x0038E3F0 File Offset: 0x0038C5F0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ShieldValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Priority = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BuffHandle = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsValid = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009086 RID: 36998
		private static readonly MessageParser<ShieldInfoPb> _parser = new MessageParser<ShieldInfoPb>(() => new ShieldInfoPb());

		// Token: 0x04009087 RID: 36999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009088 RID: 37000
		public const int HandleFieldNumber = 1;

		// Token: 0x04009089 RID: 37001
		private int handle_;

		// Token: 0x0400908A RID: 37002
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x0400908B RID: 37003
		private int configId_;

		// Token: 0x0400908C RID: 37004
		public const int ShieldValueFieldNumber = 3;

		// Token: 0x0400908D RID: 37005
		private int shieldValue_;

		// Token: 0x0400908E RID: 37006
		public const int PriorityFieldNumber = 4;

		// Token: 0x0400908F RID: 37007
		private int priority_;

		// Token: 0x04009090 RID: 37008
		public const int BuffHandleFieldNumber = 5;

		// Token: 0x04009091 RID: 37009
		private int buffHandle_;

		// Token: 0x04009092 RID: 37010
		public const int IsValidFieldNumber = 6;

		// Token: 0x04009093 RID: 37011
		private bool isValid_;
	}
}
