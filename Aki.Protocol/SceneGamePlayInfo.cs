using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001152 RID: 4434
	public sealed class SceneGamePlayInfo : IMessage<SceneGamePlayInfo>, IMessage, IEquatable<SceneGamePlayInfo>, IDeepCloneable<SceneGamePlayInfo>, IBufferMessage
	{
		// Token: 0x06017A2D RID: 96813 RVA: 0x0036E59D File Offset: 0x0036C79D
		[NullableContext(1)]
		public static SceneGamePlayInfo Create()
		{
			return new SceneGamePlayInfo();
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06017A2E RID: 96814 RVA: 0x0036E5A4 File Offset: 0x0036C7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneGamePlayInfo> Parser
		{
			get
			{
				return SceneGamePlayInfo._parser;
			}
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x06017A2F RID: 96815 RVA: 0x0036E5AB File Offset: 0x0036C7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x06017A30 RID: 96816 RVA: 0x0036E5AE File Offset: 0x0036C7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayInfo.Descriptor;
			}
		}

		// Token: 0x06017A31 RID: 96817 RVA: 0x0036E5B5 File Offset: 0x0036C7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfo()
		{
		}

		// Token: 0x06017A32 RID: 96818 RVA: 0x0036E5C0 File Offset: 0x0036C7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfo(SceneGamePlayInfo other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.isFirst_ = other.isFirst_;
			this.status_ = other.status_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A33 RID: 96819 RVA: 0x0036E614 File Offset: 0x0036C814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfo Clone()
		{
			return new SceneGamePlayInfo(this);
		}

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06017A34 RID: 96820 RVA: 0x0036E61C File Offset: 0x0036C81C
		// (set) Token: 0x06017A35 RID: 96821 RVA: 0x0036E624 File Offset: 0x0036C824
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

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06017A36 RID: 96822 RVA: 0x0036E62D File Offset: 0x0036C82D
		// (set) Token: 0x06017A37 RID: 96823 RVA: 0x0036E635 File Offset: 0x0036C835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirst
		{
			get
			{
				return this.isFirst_;
			}
			set
			{
				this.isFirst_ = value;
			}
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06017A38 RID: 96824 RVA: 0x0036E63E File Offset: 0x0036C83E
		// (set) Token: 0x06017A39 RID: 96825 RVA: 0x0036E646 File Offset: 0x0036C846
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

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06017A3A RID: 96826 RVA: 0x0036E64F File Offset: 0x0036C84F
		// (set) Token: 0x06017A3B RID: 96827 RVA: 0x0036E657 File Offset: 0x0036C857
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

		// Token: 0x06017A3C RID: 96828 RVA: 0x0036E660 File Offset: 0x0036C860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayInfo);
		}

		// Token: 0x06017A3D RID: 96829 RVA: 0x0036E670 File Offset: 0x0036C870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayInfo other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.IsFirst == other.IsFirst && this.Status == other.Status && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A3E RID: 96830 RVA: 0x0036E6DC File Offset: 0x0036C8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.IsFirst)
			{
				num ^= this.IsFirst.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
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

		// Token: 0x06017A3F RID: 96831 RVA: 0x0036E766 File Offset: 0x0036C966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A40 RID: 96832 RVA: 0x0036E773 File Offset: 0x0036C973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A41 RID: 96833 RVA: 0x0036E77C File Offset: 0x0036C97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamePlayId);
			}
			if (this.IsFirst)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsFirst);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Status);
			}
			if (this.OpenTime != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A42 RID: 96834 RVA: 0x0036E80C File Offset: 0x0036CA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.IsFirst)
			{
				num += 2;
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
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

		// Token: 0x06017A43 RID: 96835 RVA: 0x0036E888 File Offset: 0x0036CA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.IsFirst)
			{
				this.IsFirst = other.IsFirst;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.OpenTime != 0U)
			{
				this.OpenTime = other.OpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A44 RID: 96836 RVA: 0x0036E900 File Offset: 0x0036CB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A45 RID: 96837 RVA: 0x0036E90C File Offset: 0x0036CB0C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.GamePlayId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsFirst = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Status = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OpenTime = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008C4A RID: 35914
		private static readonly MessageParser<SceneGamePlayInfo> _parser = new MessageParser<SceneGamePlayInfo>(() => new SceneGamePlayInfo());

		// Token: 0x04008C4B RID: 35915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C4C RID: 35916
		public const int GamePlayIdFieldNumber = 1;

		// Token: 0x04008C4D RID: 35917
		private int gamePlayId_;

		// Token: 0x04008C4E RID: 35918
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04008C4F RID: 35919
		private bool isFirst_;

		// Token: 0x04008C50 RID: 35920
		public const int StatusFieldNumber = 3;

		// Token: 0x04008C51 RID: 35921
		private int status_;

		// Token: 0x04008C52 RID: 35922
		public const int OpenTimeFieldNumber = 4;

		// Token: 0x04008C53 RID: 35923
		private uint openTime_;
	}
}
