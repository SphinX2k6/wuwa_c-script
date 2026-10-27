using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115F RID: 4447
	[NetMessage(EMessageId.SceneItemAttributeChangeNotify)]
	public sealed class SceneItemAttributeChangeNotify : IMessage<SceneItemAttributeChangeNotify>, IMessage, IEquatable<SceneItemAttributeChangeNotify>, IDeepCloneable<SceneItemAttributeChangeNotify>, IBufferMessage
	{
		// Token: 0x06017B51 RID: 97105 RVA: 0x00371778 File Offset: 0x0036F978
		[NullableContext(1)]
		public static SceneItemAttributeChangeNotify Create()
		{
			return new SceneItemAttributeChangeNotify();
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06017B52 RID: 97106 RVA: 0x0037177F File Offset: 0x0036F97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x06017B53 RID: 97107 RVA: 0x00371782 File Offset: 0x0036F982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAttributeChangeNotify.Descriptor;
			}
		}

		// Token: 0x06017B54 RID: 97108 RVA: 0x00371789 File Offset: 0x0036F989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify()
		{
		}

		// Token: 0x06017B55 RID: 97109 RVA: 0x00371791 File Offset: 0x0036F991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify(SceneItemAttributeChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.attributeId_ = other.attributeId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B56 RID: 97110 RVA: 0x003717CE File Offset: 0x0036F9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify Clone()
		{
			return new SceneItemAttributeChangeNotify(this);
		}

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x06017B57 RID: 97111 RVA: 0x003717D6 File Offset: 0x0036F9D6
		// (set) Token: 0x06017B58 RID: 97112 RVA: 0x003717DE File Offset: 0x0036F9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x06017B59 RID: 97113 RVA: 0x003717E7 File Offset: 0x0036F9E7
		// (set) Token: 0x06017B5A RID: 97114 RVA: 0x003717EF File Offset: 0x0036F9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttributeId
		{
			get
			{
				return this.attributeId_;
			}
			set
			{
				this.attributeId_ = value;
			}
		}

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x06017B5B RID: 97115 RVA: 0x003717F8 File Offset: 0x0036F9F8
		// (set) Token: 0x06017B5C RID: 97116 RVA: 0x00371800 File Offset: 0x0036FA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x06017B5D RID: 97117 RVA: 0x00371809 File Offset: 0x0036FA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAttributeChangeNotify);
		}

		// Token: 0x06017B5E RID: 97118 RVA: 0x00371818 File Offset: 0x0036FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAttributeChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AttributeId == other.AttributeId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B5F RID: 97119 RVA: 0x00371874 File Offset: 0x0036FA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.AttributeId != 0)
			{
				num ^= this.AttributeId.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B60 RID: 97120 RVA: 0x003718E5 File Offset: 0x0036FAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B61 RID: 97121 RVA: 0x003718F2 File Offset: 0x0036FAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B62 RID: 97122 RVA: 0x003718FC File Offset: 0x0036FAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAdd);
			}
			if (this.AttributeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AttributeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B63 RID: 97123 RVA: 0x00371974 File Offset: 0x0036FB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.AttributeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttributeId);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B64 RID: 97124 RVA: 0x003719D8 File Offset: 0x0036FBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAttributeChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.AttributeId != 0)
			{
				this.AttributeId = other.AttributeId;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B65 RID: 97125 RVA: 0x00371A3C File Offset: 0x0036FC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B66 RID: 97126 RVA: 0x00371A48 File Offset: 0x0036FC48
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AttributeId = input.ReadInt32();
						}
					}
					else
					{
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008CC4 RID: 36036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CC5 RID: 36037
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04008CC6 RID: 36038
		private long entityId_;

		// Token: 0x04008CC7 RID: 36039
		public const int AttributeIdFieldNumber = 10;

		// Token: 0x04008CC8 RID: 36040
		private int attributeId_;

		// Token: 0x04008CC9 RID: 36041
		public const int IsAddFieldNumber = 8;

		// Token: 0x04008CCA RID: 36042
		private bool isAdd_;
	}
}
