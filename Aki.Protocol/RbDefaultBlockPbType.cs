using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8C RID: 3724
	public sealed class RbDefaultBlockPbType : IMessage<RbDefaultBlockPbType>, IMessage, IEquatable<RbDefaultBlockPbType>, IDeepCloneable<RbDefaultBlockPbType>, IBufferMessage
	{
		// Token: 0x06014004 RID: 81924 RVA: 0x002E9D0D File Offset: 0x002E7F0D
		[NullableContext(1)]
		public static RbDefaultBlockPbType Create()
		{
			return new RbDefaultBlockPbType();
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x06014005 RID: 81925 RVA: 0x002E9D14 File Offset: 0x002E7F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x06014006 RID: 81926 RVA: 0x002E9D17 File Offset: 0x002E7F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbDefaultBlockPbType.Descriptor;
			}
		}

		// Token: 0x06014007 RID: 81927 RVA: 0x002E9D1E File Offset: 0x002E7F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType()
		{
		}

		// Token: 0x06014008 RID: 81928 RVA: 0x002E9D26 File Offset: 0x002E7F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType(RbDefaultBlockPbType other) : this()
		{
			this.isMainControl_ = other.isMainControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014009 RID: 81929 RVA: 0x002E9D4B File Offset: 0x002E7F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType Clone()
		{
			return new RbDefaultBlockPbType(this);
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0601400A RID: 81930 RVA: 0x002E9D53 File Offset: 0x002E7F53
		// (set) Token: 0x0601400B RID: 81931 RVA: 0x002E9D5B File Offset: 0x002E7F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMainControl
		{
			get
			{
				return this.isMainControl_;
			}
			set
			{
				this.isMainControl_ = value;
			}
		}

		// Token: 0x0601400C RID: 81932 RVA: 0x002E9D64 File Offset: 0x002E7F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbDefaultBlockPbType);
		}

		// Token: 0x0601400D RID: 81933 RVA: 0x002E9D72 File Offset: 0x002E7F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbDefaultBlockPbType other)
		{
			return other != null && (other == this || (this.IsMainControl == other.IsMainControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601400E RID: 81934 RVA: 0x002E9DA0 File Offset: 0x002E7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsMainControl)
			{
				num ^= this.IsMainControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601400F RID: 81935 RVA: 0x002E9DDF File Offset: 0x002E7FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014010 RID: 81936 RVA: 0x002E9DEC File Offset: 0x002E7FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014011 RID: 81937 RVA: 0x002E9DF5 File Offset: 0x002E7FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMainControl)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsMainControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014012 RID: 81938 RVA: 0x002E9E28 File Offset: 0x002E8028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsMainControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014013 RID: 81939 RVA: 0x002E9E5A File Offset: 0x002E805A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbDefaultBlockPbType other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsMainControl)
			{
				this.IsMainControl = other.IsMainControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014014 RID: 81940 RVA: 0x002E9E8B File Offset: 0x002E808B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014015 RID: 81941 RVA: 0x002E9E94 File Offset: 0x002E8094
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
					this.IsMainControl = input.ReadBool();
				}
			}
		}

		// Token: 0x04007A26 RID: 31270
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A27 RID: 31271
		public const int IsMainControlFieldNumber = 1;

		// Token: 0x04007A28 RID: 31272
		private bool isMainControl_;
	}
}
