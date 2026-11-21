using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B0 RID: 4528
	public sealed class SceneItemSplineRuntimeData : IMessage<SceneItemSplineRuntimeData>, IMessage, IEquatable<SceneItemSplineRuntimeData>, IDeepCloneable<SceneItemSplineRuntimeData>, IBufferMessage
	{
		// Token: 0x060182E0 RID: 99040 RVA: 0x0038531D File Offset: 0x0038351D
		[NullableContext(1)]
		public static SceneItemSplineRuntimeData Create()
		{
			return new SceneItemSplineRuntimeData();
		}

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x060182E1 RID: 99041 RVA: 0x00385324 File Offset: 0x00383524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x060182E2 RID: 99042 RVA: 0x00385327 File Offset: 0x00383527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSplineRuntimeData.Descriptor;
			}
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x0038532E File Offset: 0x0038352E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData()
		{
		}

		// Token: 0x060182E4 RID: 99044 RVA: 0x00385338 File Offset: 0x00383538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData(SceneItemSplineRuntimeData other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.distanceAlongPath_ = other.distanceAlongPath_;
			this.curPos_ = ((other.curPos_ != null) ? other.curPos_.Clone() : null);
			this.curRot_ = ((other.curRot_ != null) ? other.curRot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182E5 RID: 99045 RVA: 0x003853AC File Offset: 0x003835AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData Clone()
		{
			return new SceneItemSplineRuntimeData(this);
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x060182E6 RID: 99046 RVA: 0x003853B4 File Offset: 0x003835B4
		// (set) Token: 0x060182E7 RID: 99047 RVA: 0x003853CC File Offset: 0x003835CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DistanceAlongPath
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.distanceAlongPath_;
				}
				return SceneItemSplineRuntimeData.DistanceAlongPathDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.distanceAlongPath_ = value;
			}
		}

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x060182E8 RID: 99048 RVA: 0x003853E3 File Offset: 0x003835E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDistanceAlongPath
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060182E9 RID: 99049 RVA: 0x003853F0 File Offset: 0x003835F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDistanceAlongPath()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x060182EA RID: 99050 RVA: 0x00385401 File Offset: 0x00383601
		// (set) Token: 0x060182EB RID: 99051 RVA: 0x00385409 File Offset: 0x00383609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector CurPos
		{
			get
			{
				return this.curPos_;
			}
			set
			{
				this.curPos_ = value;
			}
		}

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x060182EC RID: 99052 RVA: 0x00385412 File Offset: 0x00383612
		// (set) Token: 0x060182ED RID: 99053 RVA: 0x0038541A File Offset: 0x0038361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator CurRot
		{
			get
			{
				return this.curRot_;
			}
			set
			{
				this.curRot_ = value;
			}
		}

		// Token: 0x060182EE RID: 99054 RVA: 0x00385423 File Offset: 0x00383623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSplineRuntimeData);
		}

		// Token: 0x060182EF RID: 99055 RVA: 0x00385434 File Offset: 0x00383634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSplineRuntimeData other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DistanceAlongPath, other.DistanceAlongPath) && object.Equals(this.CurPos, other.CurPos) && object.Equals(this.CurRot, other.CurRot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182F0 RID: 99056 RVA: 0x003854A4 File Offset: 0x003836A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasDistanceAlongPath)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DistanceAlongPath);
			}
			if (this.curPos_ != null)
			{
				num ^= this.CurPos.GetHashCode();
			}
			if (this.curRot_ != null)
			{
				num ^= this.CurRot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060182F1 RID: 99057 RVA: 0x00385511 File Offset: 0x00383711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182F2 RID: 99058 RVA: 0x0038551E File Offset: 0x0038371E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182F3 RID: 99059 RVA: 0x00385528 File Offset: 0x00383728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDistanceAlongPath)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.DistanceAlongPath);
			}
			if (this.curPos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CurPos);
			}
			if (this.curRot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CurRot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182F4 RID: 99060 RVA: 0x003855A0 File Offset: 0x003837A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasDistanceAlongPath)
			{
				num += 5;
			}
			if (this.curPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurPos);
			}
			if (this.curRot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurRot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060182F5 RID: 99061 RVA: 0x00385604 File Offset: 0x00383804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSplineRuntimeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasDistanceAlongPath)
			{
				this.DistanceAlongPath = other.DistanceAlongPath;
			}
			if (other.curPos_ != null)
			{
				if (this.curPos_ == null)
				{
					this.CurPos = new Vector();
				}
				this.CurPos.MergeFrom(other.CurPos);
			}
			if (other.curRot_ != null)
			{
				if (this.curRot_ == null)
				{
					this.CurRot = new Rotator();
				}
				this.CurRot.MergeFrom(other.CurRot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060182F6 RID: 99062 RVA: 0x00385698 File Offset: 0x00383898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182F7 RID: 99063 RVA: 0x003856A4 File Offset: 0x003838A4
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
				if (num != 13U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.curRot_ == null)
							{
								this.CurRot = new Rotator();
							}
							input.ReadMessage(this.CurRot);
						}
					}
					else
					{
						if (this.curPos_ == null)
						{
							this.CurPos = new Vector();
						}
						input.ReadMessage(this.CurPos);
					}
				}
				else
				{
					this.DistanceAlongPath = input.ReadFloat();
				}
			}
		}

		// Token: 0x04008FDA RID: 36826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FDB RID: 36827
		private int _hasBits0;

		// Token: 0x04008FDC RID: 36828
		public const int DistanceAlongPathFieldNumber = 1;

		// Token: 0x04008FDD RID: 36829
		private static readonly float DistanceAlongPathDefaultValue;

		// Token: 0x04008FDE RID: 36830
		private float distanceAlongPath_;

		// Token: 0x04008FDF RID: 36831
		public const int CurPosFieldNumber = 2;

		// Token: 0x04008FE0 RID: 36832
		private Vector curPos_;

		// Token: 0x04008FE1 RID: 36833
		public const int CurRotFieldNumber = 3;

		// Token: 0x04008FE2 RID: 36834
		private Rotator curRot_;
	}
}
