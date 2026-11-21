using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118C RID: 4492
	public sealed class SceneGamePlayInfo : IMessage<SceneGamePlayInfo>, IMessage, IEquatable<SceneGamePlayInfo>, IDeepCloneable<SceneGamePlayInfo>, IBufferMessage
	{
		// Token: 0x06017FCE RID: 98254 RVA: 0x0037D8E9 File Offset: 0x0037BAE9
		[NullableContext(1)]
		public static SceneGamePlayInfo Create()
		{
			return new SceneGamePlayInfo();
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x06017FCF RID: 98255 RVA: 0x0037D8F0 File Offset: 0x0037BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneGamePlayInfo> Parser
		{
			get
			{
				return SceneGamePlayInfo._parser;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x06017FD0 RID: 98256 RVA: 0x0037D8F7 File Offset: 0x0037BAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x06017FD1 RID: 98257 RVA: 0x0037D8FA File Offset: 0x0037BAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayInfo.Descriptor;
			}
		}

		// Token: 0x06017FD2 RID: 98258 RVA: 0x0037D901 File Offset: 0x0037BB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfo()
		{
		}

		// Token: 0x06017FD3 RID: 98259 RVA: 0x0037D90C File Offset: 0x0037BB0C
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

		// Token: 0x06017FD4 RID: 98260 RVA: 0x0037D960 File Offset: 0x0037BB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfo Clone()
		{
			return new SceneGamePlayInfo(this);
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x06017FD5 RID: 98261 RVA: 0x0037D968 File Offset: 0x0037BB68
		// (set) Token: 0x06017FD6 RID: 98262 RVA: 0x0037D970 File Offset: 0x0037BB70
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

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06017FD7 RID: 98263 RVA: 0x0037D979 File Offset: 0x0037BB79
		// (set) Token: 0x06017FD8 RID: 98264 RVA: 0x0037D981 File Offset: 0x0037BB81
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

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x06017FD9 RID: 98265 RVA: 0x0037D98A File Offset: 0x0037BB8A
		// (set) Token: 0x06017FDA RID: 98266 RVA: 0x0037D992 File Offset: 0x0037BB92
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

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x06017FDB RID: 98267 RVA: 0x0037D99B File Offset: 0x0037BB9B
		// (set) Token: 0x06017FDC RID: 98268 RVA: 0x0037D9A3 File Offset: 0x0037BBA3
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

		// Token: 0x06017FDD RID: 98269 RVA: 0x0037D9AC File Offset: 0x0037BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayInfo);
		}

		// Token: 0x06017FDE RID: 98270 RVA: 0x0037D9BC File Offset: 0x0037BBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayInfo other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.IsFirst == other.IsFirst && this.Status == other.Status && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FDF RID: 98271 RVA: 0x0037DA28 File Offset: 0x0037BC28
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

		// Token: 0x06017FE0 RID: 98272 RVA: 0x0037DAB2 File Offset: 0x0037BCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FE1 RID: 98273 RVA: 0x0037DABF File Offset: 0x0037BCBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FE2 RID: 98274 RVA: 0x0037DAC8 File Offset: 0x0037BCC8
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

		// Token: 0x06017FE3 RID: 98275 RVA: 0x0037DB58 File Offset: 0x0037BD58
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

		// Token: 0x06017FE4 RID: 98276 RVA: 0x0037DBD4 File Offset: 0x0037BDD4
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

		// Token: 0x06017FE5 RID: 98277 RVA: 0x0037DC4C File Offset: 0x0037BE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FE6 RID: 98278 RVA: 0x0037DC58 File Offset: 0x0037BE58
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

		// Token: 0x04008EDD RID: 36573
		private static readonly MessageParser<SceneGamePlayInfo> _parser = new MessageParser<SceneGamePlayInfo>(() => new SceneGamePlayInfo());

		// Token: 0x04008EDE RID: 36574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EDF RID: 36575
		public const int GamePlayIdFieldNumber = 1;

		// Token: 0x04008EE0 RID: 36576
		private int gamePlayId_;

		// Token: 0x04008EE1 RID: 36577
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04008EE2 RID: 36578
		private bool isFirst_;

		// Token: 0x04008EE3 RID: 36579
		public const int StatusFieldNumber = 3;

		// Token: 0x04008EE4 RID: 36580
		private int status_;

		// Token: 0x04008EE5 RID: 36581
		public const int OpenTimeFieldNumber = 4;

		// Token: 0x04008EE6 RID: 36582
		private uint openTime_;
	}
}
