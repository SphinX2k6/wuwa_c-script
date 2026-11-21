using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001057 RID: 4183
	[NetMessage(EMessageId.RoleDevelopConfigUpdateNotify)]
	public sealed class RoleDevelopConfigUpdateNotify : IMessage<RoleDevelopConfigUpdateNotify>, IMessage, IEquatable<RoleDevelopConfigUpdateNotify>, IDeepCloneable<RoleDevelopConfigUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601660A RID: 91658 RVA: 0x00341117 File Offset: 0x0033F317
		[NullableContext(1)]
		public static RoleDevelopConfigUpdateNotify Create()
		{
			return new RoleDevelopConfigUpdateNotify();
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x0601660B RID: 91659 RVA: 0x0034111E File Offset: 0x0033F31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x0601660C RID: 91660 RVA: 0x00341121 File Offset: 0x0033F321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601660D RID: 91661 RVA: 0x00341128 File Offset: 0x0033F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify()
		{
		}

		// Token: 0x0601660E RID: 91662 RVA: 0x00341130 File Offset: 0x0033F330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify(RoleDevelopConfigUpdateNotify other) : this()
		{
			this.configs_ = ((other.configs_ != null) ? other.configs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601660F RID: 91663 RVA: 0x00341165 File Offset: 0x0033F365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigUpdateNotify Clone()
		{
			return new RoleDevelopConfigUpdateNotify(this);
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x06016610 RID: 91664 RVA: 0x0034116D File Offset: 0x0033F36D
		// (set) Token: 0x06016611 RID: 91665 RVA: 0x00341175 File Offset: 0x0033F375
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

		// Token: 0x06016612 RID: 91666 RVA: 0x0034117E File Offset: 0x0033F37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigUpdateNotify);
		}

		// Token: 0x06016613 RID: 91667 RVA: 0x0034118C File Offset: 0x0033F38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Configs, other.Configs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016614 RID: 91668 RVA: 0x003411C0 File Offset: 0x0033F3C0
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

		// Token: 0x06016615 RID: 91669 RVA: 0x003411FC File Offset: 0x0033F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016616 RID: 91670 RVA: 0x00341209 File Offset: 0x0033F409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016617 RID: 91671 RVA: 0x00341212 File Offset: 0x0033F412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.configs_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Configs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016618 RID: 91672 RVA: 0x00341244 File Offset: 0x0033F444
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

		// Token: 0x06016619 RID: 91673 RVA: 0x00341284 File Offset: 0x0033F484
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

		// Token: 0x0601661A RID: 91674 RVA: 0x003412D8 File Offset: 0x0033F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601661B RID: 91675 RVA: 0x003412E4 File Offset: 0x0033F4E4
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
				if (num != 10U)
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

		// Token: 0x04008649 RID: 34377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400864A RID: 34378
		public const int ConfigsFieldNumber = 1;

		// Token: 0x0400864B RID: 34379
		private RoleDevelopConfigs configs_;
	}
}
