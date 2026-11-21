using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7C RID: 3708
	public sealed class RbDefaultBlockPbType : IMessage<RbDefaultBlockPbType>, IMessage, IEquatable<RbDefaultBlockPbType>, IDeepCloneable<RbDefaultBlockPbType>, IBufferMessage
	{
		// Token: 0x06013F1F RID: 81695 RVA: 0x002E8651 File Offset: 0x002E6851
		[NullableContext(1)]
		public static RbDefaultBlockPbType Create()
		{
			return new RbDefaultBlockPbType();
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x06013F20 RID: 81696 RVA: 0x002E8658 File Offset: 0x002E6858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x06013F21 RID: 81697 RVA: 0x002E865B File Offset: 0x002E685B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbDefaultBlockPbType.Descriptor;
			}
		}

		// Token: 0x06013F22 RID: 81698 RVA: 0x002E8662 File Offset: 0x002E6862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType()
		{
		}

		// Token: 0x06013F23 RID: 81699 RVA: 0x002E866A File Offset: 0x002E686A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType(RbDefaultBlockPbType other) : this()
		{
			this.isMainControl_ = other.isMainControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F24 RID: 81700 RVA: 0x002E868F File Offset: 0x002E688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType Clone()
		{
			return new RbDefaultBlockPbType(this);
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x06013F25 RID: 81701 RVA: 0x002E8697 File Offset: 0x002E6897
		// (set) Token: 0x06013F26 RID: 81702 RVA: 0x002E869F File Offset: 0x002E689F
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

		// Token: 0x06013F27 RID: 81703 RVA: 0x002E86A8 File Offset: 0x002E68A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbDefaultBlockPbType);
		}

		// Token: 0x06013F28 RID: 81704 RVA: 0x002E86B6 File Offset: 0x002E68B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbDefaultBlockPbType other)
		{
			return other != null && (other == this || (this.IsMainControl == other.IsMainControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F29 RID: 81705 RVA: 0x002E86E4 File Offset: 0x002E68E4
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

		// Token: 0x06013F2A RID: 81706 RVA: 0x002E8723 File Offset: 0x002E6923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F2B RID: 81707 RVA: 0x002E8730 File Offset: 0x002E6930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F2C RID: 81708 RVA: 0x002E8739 File Offset: 0x002E6939
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

		// Token: 0x06013F2D RID: 81709 RVA: 0x002E876C File Offset: 0x002E696C
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

		// Token: 0x06013F2E RID: 81710 RVA: 0x002E879E File Offset: 0x002E699E
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

		// Token: 0x06013F2F RID: 81711 RVA: 0x002E87CF File Offset: 0x002E69CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F30 RID: 81712 RVA: 0x002E87D8 File Offset: 0x002E69D8
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

		// Token: 0x04007A50 RID: 31312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A51 RID: 31313
		public const int IsMainControlFieldNumber = 1;

		// Token: 0x04007A52 RID: 31314
		private bool isMainControl_;
	}
}
