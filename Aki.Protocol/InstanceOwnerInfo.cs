using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081B RID: 2075
	public sealed class InstanceOwnerInfo : IMessage<InstanceOwnerInfo>, IMessage, IEquatable<InstanceOwnerInfo>, IDeepCloneable<InstanceOwnerInfo>, IBufferMessage
	{
		// Token: 0x0600B972 RID: 47474 RVA: 0x001B9822 File Offset: 0x001B7A22
		[NullableContext(1)]
		public static InstanceOwnerInfo Create()
		{
			return new InstanceOwnerInfo();
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x0600B973 RID: 47475 RVA: 0x001B9829 File Offset: 0x001B7A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x0600B974 RID: 47476 RVA: 0x001B982C File Offset: 0x001B7A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceOwnerInfo.Descriptor;
			}
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x001B9833 File Offset: 0x001B7A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo()
		{
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x001B983B File Offset: 0x001B7A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo(InstanceOwnerInfo other) : this()
		{
			this.isFinishMingSuGen_ = other.isFinishMingSuGen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x001B9860 File Offset: 0x001B7A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo Clone()
		{
			return new InstanceOwnerInfo(this);
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x0600B978 RID: 47480 RVA: 0x001B9868 File Offset: 0x001B7A68
		// (set) Token: 0x0600B979 RID: 47481 RVA: 0x001B9870 File Offset: 0x001B7A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinishMingSuGen
		{
			get
			{
				return this.isFinishMingSuGen_;
			}
			set
			{
				this.isFinishMingSuGen_ = value;
			}
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x001B9879 File Offset: 0x001B7A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceOwnerInfo);
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x001B9887 File Offset: 0x001B7A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceOwnerInfo other)
		{
			return other != null && (other == this || (this.IsFinishMingSuGen == other.IsFinishMingSuGen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x001B98B8 File Offset: 0x001B7AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFinishMingSuGen)
			{
				num ^= this.IsFinishMingSuGen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x001B98F7 File Offset: 0x001B7AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x001B9904 File Offset: 0x001B7B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x001B990D File Offset: 0x001B7B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFinishMingSuGen)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFinishMingSuGen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x001B9940 File Offset: 0x001B7B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFinishMingSuGen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x001B9972 File Offset: 0x001B7B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstanceOwnerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFinishMingSuGen)
			{
				this.IsFinishMingSuGen = other.IsFinishMingSuGen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x001B99A3 File Offset: 0x001B7BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x001B99AC File Offset: 0x001B7BAC
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
					this.IsFinishMingSuGen = input.ReadBool();
				}
			}
		}

		// Token: 0x04005183 RID: 20867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005184 RID: 20868
		public const int IsFinishMingSuGenFieldNumber = 1;

		// Token: 0x04005185 RID: 20869
		private bool isFinishMingSuGen_;
	}
}
