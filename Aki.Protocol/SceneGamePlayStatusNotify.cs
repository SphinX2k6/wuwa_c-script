using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001156 RID: 4438
	[NetMessage(EMessageId.SceneGamePlayStatusNotify)]
	public sealed class SceneGamePlayStatusNotify : IMessage<SceneGamePlayStatusNotify>, IMessage, IEquatable<SceneGamePlayStatusNotify>, IDeepCloneable<SceneGamePlayStatusNotify>, IBufferMessage
	{
		// Token: 0x06017A81 RID: 96897 RVA: 0x0036F0B0 File Offset: 0x0036D2B0
		[NullableContext(1)]
		public static SceneGamePlayStatusNotify Create()
		{
			return new SceneGamePlayStatusNotify();
		}

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x06017A82 RID: 96898 RVA: 0x0036F0B7 File Offset: 0x0036D2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06017A83 RID: 96899 RVA: 0x0036F0BA File Offset: 0x0036D2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayStatusNotify.Descriptor;
			}
		}

		// Token: 0x06017A84 RID: 96900 RVA: 0x0036F0C1 File Offset: 0x0036D2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify()
		{
		}

		// Token: 0x06017A85 RID: 96901 RVA: 0x0036F0C9 File Offset: 0x0036D2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify(SceneGamePlayStatusNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A86 RID: 96902 RVA: 0x0036F0FA File Offset: 0x0036D2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify Clone()
		{
			return new SceneGamePlayStatusNotify(this);
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06017A87 RID: 96903 RVA: 0x0036F102 File Offset: 0x0036D302
		// (set) Token: 0x06017A88 RID: 96904 RVA: 0x0036F10A File Offset: 0x0036D30A
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

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x06017A89 RID: 96905 RVA: 0x0036F113 File Offset: 0x0036D313
		// (set) Token: 0x06017A8A RID: 96906 RVA: 0x0036F11B File Offset: 0x0036D31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06017A8B RID: 96907 RVA: 0x0036F124 File Offset: 0x0036D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayStatusNotify);
		}

		// Token: 0x06017A8C RID: 96908 RVA: 0x0036F132 File Offset: 0x0036D332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayStatusNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A8D RID: 96909 RVA: 0x0036F170 File Offset: 0x0036D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A8E RID: 96910 RVA: 0x0036F1C8 File Offset: 0x0036D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A8F RID: 96911 RVA: 0x0036F1D5 File Offset: 0x0036D3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x0036F1E0 File Offset: 0x0036D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GamePlayId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A91 RID: 96913 RVA: 0x0036F23C File Offset: 0x0036D43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A92 RID: 96914 RVA: 0x0036F294 File Offset: 0x0036D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayStatusNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A93 RID: 96915 RVA: 0x0036F2E4 File Offset: 0x0036D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A94 RID: 96916 RVA: 0x0036F2F0 File Offset: 0x0036D4F0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.GamePlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C62 RID: 35938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C63 RID: 35939
		public const int GamePlayIdFieldNumber = 7;

		// Token: 0x04008C64 RID: 35940
		private int gamePlayId_;

		// Token: 0x04008C65 RID: 35941
		public const int StatusFieldNumber = 12;

		// Token: 0x04008C66 RID: 35942
		private int status_;
	}
}
