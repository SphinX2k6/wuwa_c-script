using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001154 RID: 4436
	[NetMessage(EMessageId.SceneGamePlayOpenTimeNotify)]
	public sealed class SceneGamePlayOpenTimeNotify : IMessage<SceneGamePlayOpenTimeNotify>, IMessage, IEquatable<SceneGamePlayOpenTimeNotify>, IDeepCloneable<SceneGamePlayOpenTimeNotify>, IBufferMessage
	{
		// Token: 0x06017A59 RID: 96857 RVA: 0x0036EB8D File Offset: 0x0036CD8D
		[NullableContext(1)]
		public static SceneGamePlayOpenTimeNotify Create()
		{
			return new SceneGamePlayOpenTimeNotify();
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06017A5A RID: 96858 RVA: 0x0036EB94 File Offset: 0x0036CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06017A5B RID: 96859 RVA: 0x0036EB97 File Offset: 0x0036CD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayOpenTimeNotify.Descriptor;
			}
		}

		// Token: 0x06017A5C RID: 96860 RVA: 0x0036EB9E File Offset: 0x0036CD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify()
		{
		}

		// Token: 0x06017A5D RID: 96861 RVA: 0x0036EBA6 File Offset: 0x0036CDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify(SceneGamePlayOpenTimeNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A5E RID: 96862 RVA: 0x0036EBD7 File Offset: 0x0036CDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify Clone()
		{
			return new SceneGamePlayOpenTimeNotify(this);
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06017A5F RID: 96863 RVA: 0x0036EBDF File Offset: 0x0036CDDF
		// (set) Token: 0x06017A60 RID: 96864 RVA: 0x0036EBE7 File Offset: 0x0036CDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x06017A61 RID: 96865 RVA: 0x0036EBF0 File Offset: 0x0036CDF0
		// (set) Token: 0x06017A62 RID: 96866 RVA: 0x0036EBF8 File Offset: 0x0036CDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x06017A63 RID: 96867 RVA: 0x0036EC01 File Offset: 0x0036CE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayOpenTimeNotify);
		}

		// Token: 0x06017A64 RID: 96868 RVA: 0x0036EC0F File Offset: 0x0036CE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayOpenTimeNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x0036EC50 File Offset: 0x0036CE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.OpenTime != 0U)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x0036ECA8 File Offset: 0x0036CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A67 RID: 96871 RVA: 0x0036ECB5 File Offset: 0x0036CEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A68 RID: 96872 RVA: 0x0036ECC0 File Offset: 0x0036CEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamePlayId);
			}
			if (this.OpenTime != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A69 RID: 96873 RVA: 0x0036ED18 File Offset: 0x0036CF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.OpenTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A6A RID: 96874 RVA: 0x0036ED70 File Offset: 0x0036CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayOpenTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.OpenTime != 0U)
			{
				this.OpenTime = other.OpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A6B RID: 96875 RVA: 0x0036EDC0 File Offset: 0x0036CFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A6C RID: 96876 RVA: 0x0036EDCC File Offset: 0x0036CFCC
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OpenTime = input.ReadUInt32();
					}
				}
				else
				{
					this.GamePlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C58 RID: 35928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C59 RID: 35929
		public const int GamePlayIdFieldNumber = 1;

		// Token: 0x04008C5A RID: 35930
		private int gamePlayId_;

		// Token: 0x04008C5B RID: 35931
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x04008C5C RID: 35932
		private uint openTime_;
	}
}
