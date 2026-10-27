using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D42 RID: 3394
	public sealed class PinballChapterData : IMessage<PinballChapterData>, IMessage, IEquatable<PinballChapterData>, IDeepCloneable<PinballChapterData>, IBufferMessage
	{
		// Token: 0x06012500 RID: 75008 RVA: 0x002AC2B4 File Offset: 0x002AA4B4
		[NullableContext(1)]
		public static PinballChapterData Create()
		{
			return new PinballChapterData();
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x06012501 RID: 75009 RVA: 0x002AC2BB File Offset: 0x002AA4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballChapterData> Parser
		{
			get
			{
				return PinballChapterData._parser;
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x06012502 RID: 75010 RVA: 0x002AC2C2 File Offset: 0x002AA4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x06012503 RID: 75011 RVA: 0x002AC2C5 File Offset: 0x002AA4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballChapterData.Descriptor;
			}
		}

		// Token: 0x06012504 RID: 75012 RVA: 0x002AC2CC File Offset: 0x002AA4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData()
		{
		}

		// Token: 0x06012505 RID: 75013 RVA: 0x002AC2D4 File Offset: 0x002AA4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData(PinballChapterData other) : this()
		{
			this.chapterId_ = other.chapterId_;
			this.unLockTime_ = other.unLockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012506 RID: 75014 RVA: 0x002AC305 File Offset: 0x002AA505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData Clone()
		{
			return new PinballChapterData(this);
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x06012507 RID: 75015 RVA: 0x002AC30D File Offset: 0x002AA50D
		// (set) Token: 0x06012508 RID: 75016 RVA: 0x002AC315 File Offset: 0x002AA515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x06012509 RID: 75017 RVA: 0x002AC31E File Offset: 0x002AA51E
		// (set) Token: 0x0601250A RID: 75018 RVA: 0x002AC326 File Offset: 0x002AA526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnLockTime
		{
			get
			{
				return this.unLockTime_;
			}
			set
			{
				this.unLockTime_ = value;
			}
		}

		// Token: 0x0601250B RID: 75019 RVA: 0x002AC32F File Offset: 0x002AA52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballChapterData);
		}

		// Token: 0x0601250C RID: 75020 RVA: 0x002AC33D File Offset: 0x002AA53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballChapterData other)
		{
			return other != null && (other == this || (this.ChapterId == other.ChapterId && this.UnLockTime == other.UnLockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601250D RID: 75021 RVA: 0x002AC37C File Offset: 0x002AA57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.UnLockTime != 0L)
			{
				num ^= this.UnLockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601250E RID: 75022 RVA: 0x002AC3D4 File Offset: 0x002AA5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601250F RID: 75023 RVA: 0x002AC3E1 File Offset: 0x002AA5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012510 RID: 75024 RVA: 0x002AC3EC File Offset: 0x002AA5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChapterId);
			}
			if (this.UnLockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012511 RID: 75025 RVA: 0x002AC444 File Offset: 0x002AA644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.UnLockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012512 RID: 75026 RVA: 0x002AC49C File Offset: 0x002AA69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballChapterData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.UnLockTime != 0L)
			{
				this.UnLockTime = other.UnLockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012513 RID: 75027 RVA: 0x002AC4EC File Offset: 0x002AA6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012514 RID: 75028 RVA: 0x002AC4F8 File Offset: 0x002AA6F8
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
						this.UnLockTime = input.ReadInt64();
					}
				}
				else
				{
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007225 RID: 29221
		private static readonly MessageParser<PinballChapterData> _parser = new MessageParser<PinballChapterData>(() => new PinballChapterData());

		// Token: 0x04007226 RID: 29222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007227 RID: 29223
		public const int ChapterIdFieldNumber = 1;

		// Token: 0x04007228 RID: 29224
		private int chapterId_;

		// Token: 0x04007229 RID: 29225
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x0400722A RID: 29226
		private long unLockTime_;
	}
}
