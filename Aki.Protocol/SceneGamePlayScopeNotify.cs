using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118F RID: 4495
	[NetMessage(EMessageId.SceneGamePlayScopeNotify)]
	public sealed class SceneGamePlayScopeNotify : IMessage<SceneGamePlayScopeNotify>, IMessage, IEquatable<SceneGamePlayScopeNotify>, IDeepCloneable<SceneGamePlayScopeNotify>, IBufferMessage
	{
		// Token: 0x0601800E RID: 98318 RVA: 0x0037E174 File Offset: 0x0037C374
		[NullableContext(1)]
		public static SceneGamePlayScopeNotify Create()
		{
			return new SceneGamePlayScopeNotify();
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0601800F RID: 98319 RVA: 0x0037E17B File Offset: 0x0037C37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x06018010 RID: 98320 RVA: 0x0037E17E File Offset: 0x0037C37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayScopeNotify.Descriptor;
			}
		}

		// Token: 0x06018011 RID: 98321 RVA: 0x0037E185 File Offset: 0x0037C385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify()
		{
		}

		// Token: 0x06018012 RID: 98322 RVA: 0x0037E18D File Offset: 0x0037C38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify(SceneGamePlayScopeNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018013 RID: 98323 RVA: 0x0037E1BE File Offset: 0x0037C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify Clone()
		{
			return new SceneGamePlayScopeNotify(this);
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x06018014 RID: 98324 RVA: 0x0037E1C6 File Offset: 0x0037C3C6
		// (set) Token: 0x06018015 RID: 98325 RVA: 0x0037E1CE File Offset: 0x0037C3CE
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

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x06018016 RID: 98326 RVA: 0x0037E1D7 File Offset: 0x0037C3D7
		// (set) Token: 0x06018017 RID: 98327 RVA: 0x0037E1DF File Offset: 0x0037C3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x06018018 RID: 98328 RVA: 0x0037E1E8 File Offset: 0x0037C3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayScopeNotify);
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x0037E1F6 File Offset: 0x0037C3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayScopeNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601801A RID: 98330 RVA: 0x0037E234 File Offset: 0x0037C434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601801B RID: 98331 RVA: 0x0037E28C File Offset: 0x0037C48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601801C RID: 98332 RVA: 0x0037E299 File Offset: 0x0037C499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601801D RID: 98333 RVA: 0x0037E2A4 File Offset: 0x0037C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GamePlayId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601801E RID: 98334 RVA: 0x0037E300 File Offset: 0x0037C500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601801F RID: 98335 RVA: 0x0037E34C File Offset: 0x0037C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayScopeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018020 RID: 98336 RVA: 0x0037E39C File Offset: 0x0037C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018021 RID: 98337 RVA: 0x0037E3A8 File Offset: 0x0037C5A8
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnter = input.ReadBool();
					}
				}
				else
				{
					this.GamePlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EF0 RID: 36592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EF1 RID: 36593
		public const int GamePlayIdFieldNumber = 10;

		// Token: 0x04008EF2 RID: 36594
		private int gamePlayId_;

		// Token: 0x04008EF3 RID: 36595
		public const int IsEnterFieldNumber = 12;

		// Token: 0x04008EF4 RID: 36596
		private bool isEnter_;
	}
}
