using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF4 RID: 3572
	public sealed class PublicResourceVersionInfo : IMessage<PublicResourceVersionInfo>, IMessage, IEquatable<PublicResourceVersionInfo>, IDeepCloneable<PublicResourceVersionInfo>, IBufferMessage
	{
		// Token: 0x0601336B RID: 78699 RVA: 0x002CC56D File Offset: 0x002CA76D
		[NullableContext(1)]
		public static PublicResourceVersionInfo Create()
		{
			return new PublicResourceVersionInfo();
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0601336C RID: 78700 RVA: 0x002CC574 File Offset: 0x002CA774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0601336D RID: 78701 RVA: 0x002CC577 File Offset: 0x002CA777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicResourceVersionInfo.Descriptor;
			}
		}

		// Token: 0x0601336E RID: 78702 RVA: 0x002CC57E File Offset: 0x002CA77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo()
		{
		}

		// Token: 0x0601336F RID: 78703 RVA: 0x002CC586 File Offset: 0x002CA786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo(PublicResourceVersionInfo other) : this()
		{
			this.publicJsonVersion_ = other.publicJsonVersion_;
			this.publicMiscVersion_ = other.publicMiscVersion_;
			this.publicUniverseEditorVersion_ = other.publicUniverseEditorVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013370 RID: 78704 RVA: 0x002CC5C3 File Offset: 0x002CA7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo Clone()
		{
			return new PublicResourceVersionInfo(this);
		}

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x06013371 RID: 78705 RVA: 0x002CC5CB File Offset: 0x002CA7CB
		// (set) Token: 0x06013372 RID: 78706 RVA: 0x002CC5D3 File Offset: 0x002CA7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicJsonVersion
		{
			get
			{
				return this.publicJsonVersion_;
			}
			set
			{
				this.publicJsonVersion_ = value;
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x06013373 RID: 78707 RVA: 0x002CC5DC File Offset: 0x002CA7DC
		// (set) Token: 0x06013374 RID: 78708 RVA: 0x002CC5E4 File Offset: 0x002CA7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicMiscVersion
		{
			get
			{
				return this.publicMiscVersion_;
			}
			set
			{
				this.publicMiscVersion_ = value;
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x06013375 RID: 78709 RVA: 0x002CC5ED File Offset: 0x002CA7ED
		// (set) Token: 0x06013376 RID: 78710 RVA: 0x002CC5F5 File Offset: 0x002CA7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicUniverseEditorVersion
		{
			get
			{
				return this.publicUniverseEditorVersion_;
			}
			set
			{
				this.publicUniverseEditorVersion_ = value;
			}
		}

		// Token: 0x06013377 RID: 78711 RVA: 0x002CC5FE File Offset: 0x002CA7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicResourceVersionInfo);
		}

		// Token: 0x06013378 RID: 78712 RVA: 0x002CC60C File Offset: 0x002CA80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicResourceVersionInfo other)
		{
			return other != null && (other == this || (this.PublicJsonVersion == other.PublicJsonVersion && this.PublicMiscVersion == other.PublicMiscVersion && this.PublicUniverseEditorVersion == other.PublicUniverseEditorVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013379 RID: 78713 RVA: 0x002CC668 File Offset: 0x002CA868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PublicJsonVersion != 0)
			{
				num ^= this.PublicJsonVersion.GetHashCode();
			}
			if (this.PublicMiscVersion != 0)
			{
				num ^= this.PublicMiscVersion.GetHashCode();
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				num ^= this.PublicUniverseEditorVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601337A RID: 78714 RVA: 0x002CC6D9 File Offset: 0x002CA8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601337B RID: 78715 RVA: 0x002CC6E6 File Offset: 0x002CA8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601337C RID: 78716 RVA: 0x002CC6F0 File Offset: 0x002CA8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PublicJsonVersion != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PublicJsonVersion);
			}
			if (this.PublicMiscVersion != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PublicMiscVersion);
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PublicUniverseEditorVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601337D RID: 78717 RVA: 0x002CC764 File Offset: 0x002CA964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PublicJsonVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicJsonVersion);
			}
			if (this.PublicMiscVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicMiscVersion);
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicUniverseEditorVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601337E RID: 78718 RVA: 0x002CC7D4 File Offset: 0x002CA9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicResourceVersionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PublicJsonVersion != 0)
			{
				this.PublicJsonVersion = other.PublicJsonVersion;
			}
			if (other.PublicMiscVersion != 0)
			{
				this.PublicMiscVersion = other.PublicMiscVersion;
			}
			if (other.PublicUniverseEditorVersion != 0)
			{
				this.PublicUniverseEditorVersion = other.PublicUniverseEditorVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601337F RID: 78719 RVA: 0x002CC838 File Offset: 0x002CAA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013380 RID: 78720 RVA: 0x002CC844 File Offset: 0x002CAA44
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PublicUniverseEditorVersion = input.ReadInt32();
						}
					}
					else
					{
						this.PublicMiscVersion = input.ReadInt32();
					}
				}
				else
				{
					this.PublicJsonVersion = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007648 RID: 30280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007649 RID: 30281
		public const int PublicJsonVersionFieldNumber = 1;

		// Token: 0x0400764A RID: 30282
		private int publicJsonVersion_;

		// Token: 0x0400764B RID: 30283
		public const int PublicMiscVersionFieldNumber = 2;

		// Token: 0x0400764C RID: 30284
		private int publicMiscVersion_;

		// Token: 0x0400764D RID: 30285
		public const int PublicUniverseEditorVersionFieldNumber = 3;

		// Token: 0x0400764E RID: 30286
		private int publicUniverseEditorVersion_;
	}
}
