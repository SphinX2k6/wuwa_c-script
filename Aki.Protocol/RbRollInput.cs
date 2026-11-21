using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E83 RID: 3715
	public sealed class RbRollInput : IMessage<RbRollInput>, IMessage, IEquatable<RbRollInput>, IDeepCloneable<RbRollInput>, IBufferMessage
	{
		// Token: 0x06013FB1 RID: 81841 RVA: 0x002E9999 File Offset: 0x002E7B99
		[NullableContext(1)]
		public static RbRollInput Create()
		{
			return new RbRollInput();
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x06013FB2 RID: 81842 RVA: 0x002E99A0 File Offset: 0x002E7BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x06013FB3 RID: 81843 RVA: 0x002E99A3 File Offset: 0x002E7BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbRollInput.Descriptor;
			}
		}

		// Token: 0x06013FB4 RID: 81844 RVA: 0x002E99AA File Offset: 0x002E7BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput()
		{
		}

		// Token: 0x06013FB5 RID: 81845 RVA: 0x002E99B2 File Offset: 0x002E7BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput(RbRollInput other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FB6 RID: 81846 RVA: 0x002E99D7 File Offset: 0x002E7BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput Clone()
		{
			return new RbRollInput(this);
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x06013FB7 RID: 81847 RVA: 0x002E99DF File Offset: 0x002E7BDF
		// (set) Token: 0x06013FB8 RID: 81848 RVA: 0x002E99E7 File Offset: 0x002E7BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridDirection Direction
		{
			get
			{
				return this.direction_;
			}
			set
			{
				this.direction_ = value;
			}
		}

		// Token: 0x06013FB9 RID: 81849 RVA: 0x002E99F0 File Offset: 0x002E7BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbRollInput);
		}

		// Token: 0x06013FBA RID: 81850 RVA: 0x002E99FE File Offset: 0x002E7BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbRollInput other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FBB RID: 81851 RVA: 0x002E9A2C File Offset: 0x002E7C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Direction != RbGridDirection.RbForward)
			{
				num ^= this.Direction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013FBC RID: 81852 RVA: 0x002E9A71 File Offset: 0x002E7C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FBD RID: 81853 RVA: 0x002E9A7E File Offset: 0x002E7C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FBE RID: 81854 RVA: 0x002E9A87 File Offset: 0x002E7C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Direction != RbGridDirection.RbForward)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FBF RID: 81855 RVA: 0x002E9AB8 File Offset: 0x002E7CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Direction != RbGridDirection.RbForward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013FC0 RID: 81856 RVA: 0x002E9AF6 File Offset: 0x002E7CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbRollInput other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Direction != RbGridDirection.RbForward)
			{
				this.Direction = other.Direction;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013FC1 RID: 81857 RVA: 0x002E9B27 File Offset: 0x002E7D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FC2 RID: 81858 RVA: 0x002E9B30 File Offset: 0x002E7D30
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
					this.Direction = (RbGridDirection)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A77 RID: 31351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A78 RID: 31352
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A79 RID: 31353
		private RbGridDirection direction_;
	}
}
