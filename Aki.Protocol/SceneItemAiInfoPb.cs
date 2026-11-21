using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001197 RID: 4503
	public sealed class SceneItemAiInfoPb : IMessage<SceneItemAiInfoPb>, IMessage, IEquatable<SceneItemAiInfoPb>, IDeepCloneable<SceneItemAiInfoPb>, IBufferMessage
	{
		// Token: 0x060180CA RID: 98506 RVA: 0x003805A3 File Offset: 0x0037E7A3
		[NullableContext(1)]
		public static SceneItemAiInfoPb Create()
		{
			return new SceneItemAiInfoPb();
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x060180CB RID: 98507 RVA: 0x003805AA File Offset: 0x0037E7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x060180CC RID: 98508 RVA: 0x003805AD File Offset: 0x0037E7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiInfoPb.Descriptor;
			}
		}

		// Token: 0x060180CD RID: 98509 RVA: 0x003805B4 File Offset: 0x0037E7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb()
		{
		}

		// Token: 0x060180CE RID: 98510 RVA: 0x003805BC File Offset: 0x0037E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb(SceneItemAiInfoPb other) : this()
		{
			if (other.InfosCase == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				this.SceneItemPatrolInfoPb = other.SceneItemPatrolInfoPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180CF RID: 98511 RVA: 0x003805EF File Offset: 0x0037E7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb Clone()
		{
			return new SceneItemAiInfoPb(this);
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x060180D0 RID: 98512 RVA: 0x003805F7 File Offset: 0x0037E7F7
		// (set) Token: 0x060180D1 RID: 98513 RVA: 0x0038060F File Offset: 0x0037E80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb SceneItemPatrolInfoPb
		{
			get
			{
				if (this.infosCase_ != SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
				{
					return null;
				}
				return (SceneItemPatrolInfoPb)this.infos_;
			}
			set
			{
				this.infos_ = value;
				this.infosCase_ = ((value == null) ? SceneItemAiInfoPb.InfosOneofCase.None : SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb);
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x060180D2 RID: 98514 RVA: 0x00380625 File Offset: 0x0037E825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb.InfosOneofCase InfosCase
		{
			get
			{
				return this.infosCase_;
			}
		}

		// Token: 0x060180D3 RID: 98515 RVA: 0x0038062D File Offset: 0x0037E82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInfos()
		{
			this.infosCase_ = SceneItemAiInfoPb.InfosOneofCase.None;
			this.infos_ = null;
		}

		// Token: 0x060180D4 RID: 98516 RVA: 0x0038063D File Offset: 0x0037E83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiInfoPb);
		}

		// Token: 0x060180D5 RID: 98517 RVA: 0x0038064C File Offset: 0x0037E84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.SceneItemPatrolInfoPb, other.SceneItemPatrolInfoPb) && this.InfosCase == other.InfosCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180D6 RID: 98518 RVA: 0x0038069C File Offset: 0x0037E89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				num ^= this.SceneItemPatrolInfoPb.GetHashCode();
			}
			num ^= (int)this.infosCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060180D7 RID: 98519 RVA: 0x003806E2 File Offset: 0x0037E8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180D8 RID: 98520 RVA: 0x003806EF File Offset: 0x0037E8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180D9 RID: 98521 RVA: 0x003806F8 File Offset: 0x0037E8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SceneItemPatrolInfoPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180DA RID: 98522 RVA: 0x0038072C File Offset: 0x0037E92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SceneItemPatrolInfoPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180DB RID: 98523 RVA: 0x0038076C File Offset: 0x0037E96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfosCase == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				if (this.SceneItemPatrolInfoPb == null)
				{
					this.SceneItemPatrolInfoPb = new SceneItemPatrolInfoPb();
				}
				this.SceneItemPatrolInfoPb.MergeFrom(other.SceneItemPatrolInfoPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180DC RID: 98524 RVA: 0x003807C1 File Offset: 0x0037E9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180DD RID: 98525 RVA: 0x003807CC File Offset: 0x0037E9CC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					SceneItemPatrolInfoPb sceneItemPatrolInfoPb = new SceneItemPatrolInfoPb();
					if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
					{
						sceneItemPatrolInfoPb.MergeFrom(this.SceneItemPatrolInfoPb);
					}
					input.ReadMessage(sceneItemPatrolInfoPb);
					this.SceneItemPatrolInfoPb = sceneItemPatrolInfoPb;
				}
			}
		}

		// Token: 0x04008F4E RID: 36686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F4F RID: 36687
		public const int SceneItemPatrolInfoPbFieldNumber = 1;

		// Token: 0x04008F50 RID: 36688
		private object infos_;

		// Token: 0x04008F51 RID: 36689
		private SceneItemAiInfoPb.InfosOneofCase infosCase_;

		// Token: 0x02001A01 RID: 6657
		public enum InfosOneofCase
		{
			// Token: 0x0400CF26 RID: 53030
			None,
			// Token: 0x0400CF27 RID: 53031
			SceneItemPatrolInfoPb
		}
	}
}
