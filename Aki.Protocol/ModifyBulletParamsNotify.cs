using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E7 RID: 2535
	[NetMessage(EMessageId.ModifyBulletParamsNotify)]
	public sealed class ModifyBulletParamsNotify : IMessage<ModifyBulletParamsNotify>, IMessage, IEquatable<ModifyBulletParamsNotify>, IDeepCloneable<ModifyBulletParamsNotify>, IBufferMessage
	{
		// Token: 0x0600DE21 RID: 56865 RVA: 0x002095AC File Offset: 0x002077AC
		[NullableContext(1)]
		public static ModifyBulletParamsNotify Create()
		{
			return new ModifyBulletParamsNotify();
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x002095B3 File Offset: 0x002077B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0600DE23 RID: 56867 RVA: 0x002095B6 File Offset: 0x002077B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsNotify.Descriptor;
			}
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x002095BD File Offset: 0x002077BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify()
		{
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x002095C5 File Offset: 0x002077C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify(ModifyBulletParamsNotify other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x002095FA File Offset: 0x002077FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify Clone()
		{
			return new ModifyBulletParamsNotify(this);
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x00209602 File Offset: 0x00207802
		// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x0020960A File Offset: 0x0020780A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams ModifyBulletParams
		{
			get
			{
				return this.modifyBulletParams_;
			}
			set
			{
				this.modifyBulletParams_ = value;
			}
		}

		// Token: 0x0600DE29 RID: 56873 RVA: 0x00209613 File Offset: 0x00207813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsNotify);
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x00209621 File Offset: 0x00207821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x00209654 File Offset: 0x00207854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifyBulletParams_ != null)
			{
				num ^= this.ModifyBulletParams.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x00209690 File Offset: 0x00207890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x0020969D File Offset: 0x0020789D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x002096A6 File Offset: 0x002078A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x002096D8 File Offset: 0x002078D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifyBulletParams_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x00209718 File Offset: 0x00207918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifyBulletParams_ != null)
			{
				if (this.modifyBulletParams_ == null)
				{
					this.ModifyBulletParams = new ModifyBulletParams();
				}
				this.ModifyBulletParams.MergeFrom(other.ModifyBulletParams);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x0020976C File Offset: 0x0020796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x00209778 File Offset: 0x00207978
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.modifyBulletParams_ == null)
					{
						this.ModifyBulletParams = new ModifyBulletParams();
					}
					input.ReadMessage(this.ModifyBulletParams);
				}
			}
		}

		// Token: 0x04005BC7 RID: 23495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BC8 RID: 23496
		public const int ModifyBulletParamsFieldNumber = 6;

		// Token: 0x04005BC9 RID: 23497
		private ModifyBulletParams modifyBulletParams_;
	}
}
