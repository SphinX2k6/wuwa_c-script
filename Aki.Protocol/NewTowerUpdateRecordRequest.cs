using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B42 RID: 2882
	[NetMessage(EMessageId.NewTowerUpdateRecordRequest)]
	public sealed class NewTowerUpdateRecordRequest : IMessage<NewTowerUpdateRecordRequest>, IMessage, IEquatable<NewTowerUpdateRecordRequest>, IDeepCloneable<NewTowerUpdateRecordRequest>, IBufferMessage
	{
		// Token: 0x0600FA3B RID: 64059 RVA: 0x00247D48 File Offset: 0x00245F48
		[NullableContext(1)]
		public static NewTowerUpdateRecordRequest Create()
		{
			return new NewTowerUpdateRecordRequest();
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600FA3C RID: 64060 RVA: 0x00247D4F File Offset: 0x00245F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600FA3D RID: 64061 RVA: 0x00247D52 File Offset: 0x00245F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600FA3E RID: 64062 RVA: 0x00247D59 File Offset: 0x00245F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest()
		{
		}

		// Token: 0x0600FA3F RID: 64063 RVA: 0x00247D61 File Offset: 0x00245F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest(NewTowerUpdateRecordRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA40 RID: 64064 RVA: 0x00247D86 File Offset: 0x00245F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest Clone()
		{
			return new NewTowerUpdateRecordRequest(this);
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600FA41 RID: 64065 RVA: 0x00247D8E File Offset: 0x00245F8E
		// (set) Token: 0x0600FA42 RID: 64066 RVA: 0x00247D96 File Offset: 0x00245F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0600FA43 RID: 64067 RVA: 0x00247D9F File Offset: 0x00245F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordRequest);
		}

		// Token: 0x0600FA44 RID: 64068 RVA: 0x00247DAD File Offset: 0x00245FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA45 RID: 64069 RVA: 0x00247DDC File Offset: 0x00245FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA46 RID: 64070 RVA: 0x00247E1B File Offset: 0x0024601B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA47 RID: 64071 RVA: 0x00247E28 File Offset: 0x00246028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA48 RID: 64072 RVA: 0x00247E31 File Offset: 0x00246031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA49 RID: 64073 RVA: 0x00247E64 File Offset: 0x00246064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA4A RID: 64074 RVA: 0x00247EA2 File Offset: 0x002460A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA4B RID: 64075 RVA: 0x00247ED3 File Offset: 0x002460D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA4C RID: 64076 RVA: 0x00247EDC File Offset: 0x002460DC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006486 RID: 25734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006487 RID: 25735
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04006488 RID: 25736
		private int levelId_;
	}
}
