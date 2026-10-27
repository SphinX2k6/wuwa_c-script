using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E8 RID: 2536
	[NetMessage(EMessageId.ModifyBulletParamsPush)]
	public sealed class ModifyBulletParamsPush : IMessage<ModifyBulletParamsPush>, IMessage, IEquatable<ModifyBulletParamsPush>, IDeepCloneable<ModifyBulletParamsPush>, IBufferMessage
	{
		// Token: 0x0600DE33 RID: 56883 RVA: 0x002097D0 File Offset: 0x002079D0
		[NullableContext(1)]
		public static ModifyBulletParamsPush Create()
		{
			return new ModifyBulletParamsPush();
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0600DE34 RID: 56884 RVA: 0x002097D7 File Offset: 0x002079D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x002097DA File Offset: 0x002079DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsPush.Descriptor;
			}
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x002097E1 File Offset: 0x002079E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush()
		{
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x002097E9 File Offset: 0x002079E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush(ModifyBulletParamsPush other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x0020981E File Offset: 0x00207A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush Clone()
		{
			return new ModifyBulletParamsPush(this);
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x00209826 File Offset: 0x00207A26
		// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x0020982E File Offset: 0x00207A2E
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

		// Token: 0x0600DE3B RID: 56891 RVA: 0x00209837 File Offset: 0x00207A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsPush);
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00209845 File Offset: 0x00207A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsPush other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x00209878 File Offset: 0x00207A78
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

		// Token: 0x0600DE3E RID: 56894 RVA: 0x002098B4 File Offset: 0x00207AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x002098C1 File Offset: 0x00207AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x002098CA File Offset: 0x00207ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x002098FC File Offset: 0x00207AFC
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

		// Token: 0x0600DE42 RID: 56898 RVA: 0x0020993C File Offset: 0x00207B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsPush other)
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

		// Token: 0x0600DE43 RID: 56899 RVA: 0x00209990 File Offset: 0x00207B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE44 RID: 56900 RVA: 0x0020999C File Offset: 0x00207B9C
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
				if (num != 34U)
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

		// Token: 0x04005BCA RID: 23498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BCB RID: 23499
		public const int ModifyBulletParamsFieldNumber = 4;

		// Token: 0x04005BCC RID: 23500
		private ModifyBulletParams modifyBulletParams_;
	}
}
