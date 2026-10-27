using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001067 RID: 4199
	[NetMessage(EMessageId.RoleDevelopConfigUpdateNotify)]
	public sealed class RoleDevelopConfigUpdateNotify : IMessage<RoleDevelopConfigUpdateNotify>, IMessage, IEquatable<RoleDevelopConfigUpdateNotify>, IDeepCloneable<RoleDevelopConfigUpdateNotify>, IBufferMessage
	{
		// Token: 0x060166EF RID: 91887 RVA: 0x003427EB File Offset: 0x003409EB
		[NullableContext(1)]
		public static RoleDevelopConfigUpdateNotify Create()
		{
			return new RoleDevelopConfigUpdateNotify();
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x060166F0 RID: 91888 RVA: 0x003427F2 File Offset: 0x003409F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x060166F1 RID: 91889 RVA: 0x003427F5 File Offset: 0x003409F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060166F2 RID: 91890 RVA: 0x003427FC File Offset: 0x003409FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify()
		{
		}

		// Token: 0x060166F3 RID: 91891 RVA: 0x00342804 File Offset: 0x00340A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify(RoleDevelopConfigUpdateNotify other) : this()
		{
			this.configs_ = ((other.configs_ != null) ? other.configs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166F4 RID: 91892 RVA: 0x00342839 File Offset: 0x00340A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify Clone()
		{
			return new RoleDevelopConfigUpdateNotify(this);
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x060166F5 RID: 91893 RVA: 0x00342841 File Offset: 0x00340A41
		// (set) Token: 0x060166F6 RID: 91894 RVA: 0x00342849 File Offset: 0x00340A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs Configs
		{
			get
			{
				return this.configs_;
			}
			set
			{
				this.configs_ = value;
			}
		}

		// Token: 0x060166F7 RID: 91895 RVA: 0x00342852 File Offset: 0x00340A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigUpdateNotify);
		}

		// Token: 0x060166F8 RID: 91896 RVA: 0x00342860 File Offset: 0x00340A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Configs, other.Configs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166F9 RID: 91897 RVA: 0x00342894 File Offset: 0x00340A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.configs_ != null)
			{
				num ^= this.Configs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166FA RID: 91898 RVA: 0x003428D0 File Offset: 0x00340AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166FB RID: 91899 RVA: 0x003428DD File Offset: 0x00340ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166FC RID: 91900 RVA: 0x003428E6 File Offset: 0x00340AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.configs_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Configs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166FD RID: 91901 RVA: 0x00342918 File Offset: 0x00340B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.configs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Configs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166FE RID: 91902 RVA: 0x00342958 File Offset: 0x00340B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.configs_ != null)
			{
				if (this.configs_ == null)
				{
					this.Configs = new RoleDevelopConfigs();
				}
				this.Configs.MergeFrom(other.Configs);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166FF RID: 91903 RVA: 0x003429AC File Offset: 0x00340BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016700 RID: 91904 RVA: 0x003429B8 File Offset: 0x00340BB8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.configs_ == null)
					{
						this.Configs = new RoleDevelopConfigs();
					}
					input.ReadMessage(this.Configs);
				}
			}
		}

		// Token: 0x0400861F RID: 34335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008620 RID: 34336
		public const int ConfigsFieldNumber = 4;

		// Token: 0x04008621 RID: 34337
		private RoleDevelopConfigs configs_;
	}
}
