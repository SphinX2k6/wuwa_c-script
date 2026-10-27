using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF4 RID: 4084
	public sealed class RogueResMiracleCreation : IMessage<RogueResMiracleCreation>, IMessage, IEquatable<RogueResMiracleCreation>, IDeepCloneable<RogueResMiracleCreation>, IBufferMessage
	{
		// Token: 0x06015D48 RID: 89416 RVA: 0x0032BB58 File Offset: 0x00329D58
		[NullableContext(1)]
		public static RogueResMiracleCreation Create()
		{
			return new RogueResMiracleCreation();
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x06015D49 RID: 89417 RVA: 0x0032BB5F File Offset: 0x00329D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06015D4A RID: 89418 RVA: 0x0032BB62 File Offset: 0x00329D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMiracleCreation.Descriptor;
			}
		}

		// Token: 0x06015D4B RID: 89419 RVA: 0x0032BB69 File Offset: 0x00329D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation()
		{
		}

		// Token: 0x06015D4C RID: 89420 RVA: 0x0032BB71 File Offset: 0x00329D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation(RogueResMiracleCreation other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D4D RID: 89421 RVA: 0x0032BBA2 File Offset: 0x00329DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation Clone()
		{
			return new RogueResMiracleCreation(this);
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06015D4E RID: 89422 RVA: 0x0032BBAA File Offset: 0x00329DAA
		// (set) Token: 0x06015D4F RID: 89423 RVA: 0x0032BBB2 File Offset: 0x00329DB2
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

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06015D50 RID: 89424 RVA: 0x0032BBBB File Offset: 0x00329DBB
		// (set) Token: 0x06015D51 RID: 89425 RVA: 0x0032BBC3 File Offset: 0x00329DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06015D52 RID: 89426 RVA: 0x0032BBCC File Offset: 0x00329DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMiracleCreation);
		}

		// Token: 0x06015D53 RID: 89427 RVA: 0x0032BBDA File Offset: 0x00329DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMiracleCreation other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D54 RID: 89428 RVA: 0x0032BC18 File Offset: 0x00329E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D55 RID: 89429 RVA: 0x0032BC70 File Offset: 0x00329E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D56 RID: 89430 RVA: 0x0032BC7D File Offset: 0x00329E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D57 RID: 89431 RVA: 0x0032BC88 File Offset: 0x00329E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D58 RID: 89432 RVA: 0x0032BCE0 File Offset: 0x00329EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D59 RID: 89433 RVA: 0x0032BD2C File Offset: 0x00329F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMiracleCreation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D5A RID: 89434 RVA: 0x0032BD7C File Offset: 0x00329F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D5B RID: 89435 RVA: 0x0032BD88 File Offset: 0x00329F88
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040082FB RID: 33531
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082FC RID: 33532
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040082FD RID: 33533
		private int configId_;

		// Token: 0x040082FE RID: 33534
		public const int IsNewFieldNumber = 2;

		// Token: 0x040082FF RID: 33535
		private bool isNew_;
	}
}
