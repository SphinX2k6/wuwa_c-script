using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B3 RID: 1971
	public sealed class HookLockPointComponentPb : IMessage<HookLockPointComponentPb>, IMessage, IEquatable<HookLockPointComponentPb>, IDeepCloneable<HookLockPointComponentPb>, IBufferMessage
	{
		// Token: 0x0600B189 RID: 45449 RVA: 0x001A999B File Offset: 0x001A7B9B
		[NullableContext(1)]
		public static HookLockPointComponentPb Create()
		{
			return new HookLockPointComponentPb();
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x001A99A2 File Offset: 0x001A7BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600B18B RID: 45451 RVA: 0x001A99A5 File Offset: 0x001A7BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointComponentPb.Descriptor;
			}
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x001A99AC File Offset: 0x001A7BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb()
		{
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x001A99B4 File Offset: 0x001A7BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb(HookLockPointComponentPb other) : this()
		{
			this.isDisabled_ = other.isDisabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x001A99D9 File Offset: 0x001A7BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb Clone()
		{
			return new HookLockPointComponentPb(this);
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600B18F RID: 45455 RVA: 0x001A99E1 File Offset: 0x001A7BE1
		// (set) Token: 0x0600B190 RID: 45456 RVA: 0x001A99E9 File Offset: 0x001A7BE9
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

		// Token: 0x0600B191 RID: 45457 RVA: 0x001A99F2 File Offset: 0x001A7BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointComponentPb);
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x001A9A00 File Offset: 0x001A7C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointComponentPb other)
		{
			return other != null && (other == this || (this.IsDisabled == other.IsDisabled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x001A9A30 File Offset: 0x001A7C30
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

		// Token: 0x0600B194 RID: 45460 RVA: 0x001A9A6F File Offset: 0x001A7C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x001A9A7C File Offset: 0x001A7C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x001A9A85 File Offset: 0x001A7C85
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

		// Token: 0x0600B197 RID: 45463 RVA: 0x001A9AB8 File Offset: 0x001A7CB8
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

		// Token: 0x0600B198 RID: 45464 RVA: 0x001A9AEA File Offset: 0x001A7CEA
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

		// Token: 0x0600B199 RID: 45465 RVA: 0x001A9B1B File Offset: 0x001A7D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x001A9B24 File Offset: 0x001A7D24
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

		// Token: 0x04004F95 RID: 20373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F96 RID: 20374
		public const int IsDisabledFieldNumber = 1;

		// Token: 0x04004F97 RID: 20375
		private bool isDisabled_;
	}
}
