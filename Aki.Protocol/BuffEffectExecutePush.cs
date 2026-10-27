using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FB RID: 507
	[NetMessage(EMessageId.BuffEffectExecutePush)]
	public sealed class BuffEffectExecutePush : IMessage<BuffEffectExecutePush>, IMessage, IEquatable<BuffEffectExecutePush>, IDeepCloneable<BuffEffectExecutePush>, IBufferMessage
	{
		// Token: 0x06003854 RID: 14420 RVA: 0x0008CCFD File Offset: 0x0008AEFD
		[NullableContext(1)]
		public static BuffEffectExecutePush Create()
		{
			return new BuffEffectExecutePush();
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0008CD04 File Offset: 0x0008AF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x0008CD07 File Offset: 0x0008AF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecutePush.Descriptor;
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0008CD0E File Offset: 0x0008AF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0008CD16 File Offset: 0x0008AF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush(BuffEffectExecutePush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0008CD47 File Offset: 0x0008AF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush Clone()
		{
			return new BuffEffectExecutePush(this);
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x0008CD4F File Offset: 0x0008AF4F
		// (set) Token: 0x0600385B RID: 14427 RVA: 0x0008CD57 File Offset: 0x0008AF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600385C RID: 14428 RVA: 0x0008CD60 File Offset: 0x0008AF60
		// (set) Token: 0x0600385D RID: 14429 RVA: 0x0008CD68 File Offset: 0x0008AF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0008CD71 File Offset: 0x0008AF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecutePush);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x0008CD7F File Offset: 0x0008AF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecutePush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0008CDC0 File Offset: 0x0008AFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0008CE18 File Offset: 0x0008B018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x0008CE25 File Offset: 0x0008B025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0008CE30 File Offset: 0x0008B030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x0008CE8C File Offset: 0x0008B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x0008CEE4 File Offset: 0x0008B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecutePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x0008CF34 File Offset: 0x0008B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x0008CF40 File Offset: 0x0008B140
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.HandleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002B30 RID: 11056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B31 RID: 11057
		public const int HandleIdFieldNumber = 2;

		// Token: 0x04002B32 RID: 11058
		private int handleId_;

		// Token: 0x04002B33 RID: 11059
		public const int IndexFieldNumber = 13;

		// Token: 0x04002B34 RID: 11060
		private int index_;
	}
}
