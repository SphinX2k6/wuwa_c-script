using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001265 RID: 4709
	public sealed class SimpleCombatSplineMovePbType : IMessage<SimpleCombatSplineMovePbType>, IMessage, IEquatable<SimpleCombatSplineMovePbType>, IDeepCloneable<SimpleCombatSplineMovePbType>, IBufferMessage
	{
		// Token: 0x06019243 RID: 102979 RVA: 0x003AAE14 File Offset: 0x003A9014
		[NullableContext(1)]
		public static SimpleCombatSplineMovePbType Create()
		{
			return new SimpleCombatSplineMovePbType();
		}

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x06019244 RID: 102980 RVA: 0x003AAE1B File Offset: 0x003A901B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x06019245 RID: 102981 RVA: 0x003AAE1E File Offset: 0x003A901E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatSplineMovePbType.Descriptor;
			}
		}

		// Token: 0x06019246 RID: 102982 RVA: 0x003AAE25 File Offset: 0x003A9025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType()
		{
		}

		// Token: 0x06019247 RID: 102983 RVA: 0x003AAE2D File Offset: 0x003A902D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType(SimpleCombatSplineMovePbType other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019248 RID: 102984 RVA: 0x003AAE52 File Offset: 0x003A9052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType Clone()
		{
			return new SimpleCombatSplineMovePbType(this);
		}

		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x06019249 RID: 102985 RVA: 0x003AAE5A File Offset: 0x003A905A
		// (set) Token: 0x0601924A RID: 102986 RVA: 0x003AAE62 File Offset: 0x003A9062
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

		// Token: 0x0601924B RID: 102987 RVA: 0x003AAE6B File Offset: 0x003A906B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatSplineMovePbType);
		}

		// Token: 0x0601924C RID: 102988 RVA: 0x003AAE79 File Offset: 0x003A9079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatSplineMovePbType other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601924D RID: 102989 RVA: 0x003AAEA8 File Offset: 0x003A90A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601924E RID: 102990 RVA: 0x003AAEE7 File Offset: 0x003A90E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601924F RID: 102991 RVA: 0x003AAEF4 File Offset: 0x003A90F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019250 RID: 102992 RVA: 0x003AAEFD File Offset: 0x003A90FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019251 RID: 102993 RVA: 0x003AAF30 File Offset: 0x003A9130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019252 RID: 102994 RVA: 0x003AAF6E File Offset: 0x003A916E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatSplineMovePbType other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019253 RID: 102995 RVA: 0x003AAF9F File Offset: 0x003A919F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019254 RID: 102996 RVA: 0x003AAFA8 File Offset: 0x003A91A8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094E2 RID: 38114
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094E3 RID: 38115
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x040094E4 RID: 38116
		private int configId_;
	}
}
