using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079F RID: 1951
	public sealed class HookLockPointComponentPb : IMessage<HookLockPointComponentPb>, IMessage, IEquatable<HookLockPointComponentPb>, IDeepCloneable<HookLockPointComponentPb>, IBufferMessage
	{
		// Token: 0x0600B033 RID: 45107 RVA: 0x001A6F6B File Offset: 0x001A516B
		[NullableContext(1)]
		public static HookLockPointComponentPb Create()
		{
			return new HookLockPointComponentPb();
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x0600B034 RID: 45108 RVA: 0x001A6F72 File Offset: 0x001A5172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x001A6F75 File Offset: 0x001A5175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointComponentPb.Descriptor;
			}
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x001A6F7C File Offset: 0x001A517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb()
		{
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x001A6F84 File Offset: 0x001A5184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb(HookLockPointComponentPb other) : this()
		{
			this.isDisabled_ = other.isDisabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x001A6FA9 File Offset: 0x001A51A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb Clone()
		{
			return new HookLockPointComponentPb(this);
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x001A6FB1 File Offset: 0x001A51B1
		// (set) Token: 0x0600B03A RID: 45114 RVA: 0x001A6FB9 File Offset: 0x001A51B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisabled
		{
			get
			{
				return this.isDisabled_;
			}
			set
			{
				this.isDisabled_ = value;
			}
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x001A6FC2 File Offset: 0x001A51C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointComponentPb);
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x001A6FD0 File Offset: 0x001A51D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointComponentPb other)
		{
			return other != null && (other == this || (this.IsDisabled == other.IsDisabled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x001A7000 File Offset: 0x001A5200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsDisabled)
			{
				num ^= this.IsDisabled.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x001A703F File Offset: 0x001A523F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x001A704C File Offset: 0x001A524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x001A7055 File Offset: 0x001A5255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDisabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsDisabled);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x001A7088 File Offset: 0x001A5288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsDisabled)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x001A70BA File Offset: 0x001A52BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsDisabled)
			{
				this.IsDisabled = other.IsDisabled;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x001A70EB File Offset: 0x001A52EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x001A70F4 File Offset: 0x001A52F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsDisabled = input.ReadBool();
				}
			}
		}

		// Token: 0x04004F8E RID: 20366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F8F RID: 20367
		public const int IsDisabledFieldNumber = 1;

		// Token: 0x04004F90 RID: 20368
		private bool isDisabled_;
	}
}
